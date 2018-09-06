using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ManagementMeetingsTracker.BE;

namespace ManagementMeetingsTracker.BL
{
    public class MeetingItemLogic
    {
        #region Read Methods

        public List<MeetingItem> GetAllMeettingItems()
        {
            using (ManagementMeetingsEntities ctx = new ManagementMeetingsEntities())
            {
                return ctx.MeetingItems.ToList();
            }
        }

        public List<MeetingItem> GetAllMeettingItems(int MeetingId)
        {
            using (ManagementMeetingsEntities ctx = new ManagementMeetingsEntities())
            {
                return ctx.MeetingItems.Where(x => x.MeetingId == MeetingId).ToList();
            }
        }

        public MeetingItem GetMeettingItem(int MeetingItemId)
        {
            using (ManagementMeetingsEntities ctx = new ManagementMeetingsEntities())
            {
                return ctx.MeetingItems.SingleOrDefault(x => x.MeetingItemId == MeetingItemId);
            }
        }

        #endregion

        #region Modify Methods

        public void AddMeetingItem(MeetingItem MeetingItem)
        {
            using (ManagementMeetingsEntities ctx = new ManagementMeetingsEntities())
            {
                if (MeetingItem.MeetingItemId == 0)
                {
                    MeetingItem.MeetingItemStatusId = 1;
                }

                ctx.MeetingItems.Add(MeetingItem);
                ctx.SaveChanges();
            }
        }

        public void ModifyMeetingItem(MeetingItem updatedMeetingItem)
        {
            using (ManagementMeetingsEntities ctx = new ManagementMeetingsEntities())
            {
                ctx.MeetingItems.Add(updatedMeetingItem);
                ctx.Entry(updatedMeetingItem).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        #endregion
    }
}