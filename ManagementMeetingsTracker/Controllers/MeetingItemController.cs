using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ManagementMeetingsTracker.BE;
using ManagementMeetingsTracker.BL;
using ManagementMeetingsTracker.Models;

namespace ManagementMeetingsTracker.Controllers
{
    public partial class MeetingItemController : Controller
    {    
        [HttpGet]
        public virtual async Task<ActionResult> GetAddEditMeetingItem(int MeetingId, int? MeetingItemId)
        {
            MeetingItemModel model = new MeetingItemModel();

            model.MeetingId = MeetingId;
            model.MeetingItemId = MeetingItemId ?? 0;

            MeetingItemLogic miLogic = new MeetingItemLogic();
            MeetingItemStausLogic misLogic = new MeetingItemStausLogic();

            MeetingItem meetingItem = null;

            if (MeetingItemId.HasValue && MeetingItemId.Value > 0)
            {
                meetingItem = miLogic.GetMeettingItem(MeetingItemId.Value);

                model.ActionBy = meetingItem.ActionBy;
                model.MeetingItemId = meetingItem.MeetingItemId;
                model.MeetingItem = meetingItem.MeetingItem1;
                model.MeetingItemStatusId = meetingItem.MeetingItemStatusId;
                model.Remark = meetingItem.Remark;
            }

            model.MeetingItemStatuses = (from x in misLogic.GetAllMeettingItemStatuses()
                                         select new SelectListItem
                                         {
                                             Text = x.Description,
                                             Value = x.MeetigItemStatusId.ToString(),
                                             Selected = meetingItem != null ? meetingItem.MeetingItemStatusId == x.MeetigItemStatusId : false 
                                         }).ToList();

            return PartialView(MVC.MeetingItem.Views.Partial._GetAddMeetingItem, model);
        }

        [HttpGet]
        public virtual async Task<ActionResult> GetMeetingItems(int MeetingId)
        {
            MeetingItemModel model = new MeetingItemModel();

            MeetingItemLogic mil = new MeetingItemLogic();
           

            model.MeetingItems = (from x in mil.GetAllMeettingItems(MeetingId)
                                  select new MeetingItemModel
                                  {
                                      MeetingItemId = x.MeetingItemId,
                                      MeetingId = x.MeetingId,
                                      Remark = x.Remark,
                                      MeetingItem = x.MeetingItem1,
                                      MeetingItemStatusId = x.MeetingItemStatusId,
                                      MeetingItemStatusDescription = MeetingItemStausLogic.GetMeetingItemStatusDescription(x.MeetingItemStatusId)
                                  }
                                 ).ToList();

            return PartialView(MVC.MeetingItem.Views.Partial._GetMeetingItems, model);
        }

        [HttpPost]
        public virtual async Task<ActionResult> SaveMeetingItem(MeetingItemModel model)
        {
            MeetingItem meetingItem = new MeetingItem();
           
            meetingItem.MeetingId = model.MeetingId;
            meetingItem.Remark = model.Remark;
            meetingItem.MeetingItemStatusId = model.MeetingItemStatusId;
            meetingItem.MeetingItem1 = model.MeetingItem;
            meetingItem.MeetingItemId = model.MeetingItemId;

            // TODO: Setting actionby to correct user
            meetingItem.ActionBy = model.ActionBy;

            MeetingItemLogic ml = new MeetingItemLogic();

            if (model.MeetingItemId > 0)
            {
                ml.ModifyMeetingItem(meetingItem);
            }
            else
            {               
                ml.AddMeetingItem(meetingItem);
            }

            return RedirectToAction(MVC.Meeting.GetMeeting(model.MeetingId));
        }
    }
}