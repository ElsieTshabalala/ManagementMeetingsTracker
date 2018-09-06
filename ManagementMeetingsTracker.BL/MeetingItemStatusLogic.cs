using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ManagementMeetingsTracker.BE;

namespace ManagementMeetingsTracker.BL
{
    public class MeetingItemStausLogic
    {
        #region Read Methods

        public List<MeetingItemStatu> GetAllMeettingItemStatuses()
        {
            using (ManagementMeetingsEntities ctx = new ManagementMeetingsEntities())
            {
                return ctx.MeetingItemStatus.ToList();
            }
        }        

        public MeetingItemStatu GetMeettingItemStatus(int MeetingItemStatusId)
        {
            using (ManagementMeetingsEntities ctx = new ManagementMeetingsEntities())
            {
                return ctx.MeetingItemStatus.SingleOrDefault(x => x.MeetigItemStatusId == MeetingItemStatusId);
            }
        }

        public static string GetMeetingItemStatusDescription(int MeetingItemStatusId)
        {
            using (ManagementMeetingsEntities ctx = new ManagementMeetingsEntities())
            {
                return ctx.MeetingItemStatus.SingleOrDefault(x => x.MeetigItemStatusId == MeetingItemStatusId).Description;
            }
        }

        #endregion     
    }
}