using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using ManagementMeetingsTracker.BE;
using ManagementMeetingsTracker.BL;
using ManagementMeetingsTracker.Models;

namespace ManagementMeetingsTracker.Controllers
{
    public partial class MeetingTypeController : Controller
    {
        // GET: Meetings

        [HttpGet]
        public virtual async Task<ActionResult> Index()
        {
            MeetingTypeModel model = new MeetingTypeModel();

            MeetingTypeLogic mtLogic = new MeetingTypeLogic();

            model.MeetingTypes = (from x in mtLogic.GetAllMeettingTypes()
                                 select new MeetingTypeModel
                                 {
                                     MeetingTypeId = x.MeetingTypeId,
                                     MeetingType = x.MeetingType1
                                 }).ToList();                                 

            return View(MVC.MeetingTypes.Views.GetAllMeetingTypes, model);
        }       

        [HttpGet]
        public virtual async Task<ActionResult> GetMeetingType(int MeetingTypeId)
        {
            MeetingTypeModel model = new MeetingTypeModel();

            MeetingTypeLogic mtLogic = new MeetingTypeLogic();

            BE.MeetingType meetingType = mtLogic.GetMeettingType(MeetingTypeId);

            model.MeetingTypeId = meetingType.MeetingTypeId;
            model.MeetingType = meetingType.Description;

            return View(MVC.MeetingTypes.Views.GetMeetingType, model);
        }

        [HttpGet]
        public virtual async Task<ActionResult> GetAddMeetingType()
        {
            MeetingTypeModel model = new MeetingTypeModel();           
            

            return View(MVC.MeetingTypes.Views.GetAddMeetingType, model);
        }

        [HttpPost]
        public virtual async Task<ActionResult> SaveMeetingType(MeetingTypeModel model)
        {
            MeetingTypeLogic mtLogic = new MeetingTypeLogic();

            BE.MeetingType meetingType = new BE.MeetingType();

            meetingType.MeetingType1 = model.MeetingType;

            mtLogic.AddMeetingType(meetingType);

            return RedirectToAction(MVC.MeetingType.Index());
        }
    }
}