using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ManagementMeetingsTracker.BE;

namespace ManagementMeetingsTracker.BL
{
    public class MeetingLogic
    {
        #region Read Methods
        
        public List<Meeting> GetAllMeettings()
        {
            using (ManagementMeetingsEntities ctx = new ManagementMeetingsEntities())
            {
                return ctx.Meetings.ToList();
            }
        }

        public Meeting GetMeetting(int MeetingId)
        {
            using (ManagementMeetingsEntities ctx = new ManagementMeetingsEntities())
            {
                return ctx.Meetings.SingleOrDefault(x => x.MeetingId == MeetingId);
            }
        }

        #endregion

        #region Modify Methods

        public void AddMeeting(Meeting meeting)
        {
            try
            {
                using (ManagementMeetingsEntities ctx = new ManagementMeetingsEntities())
                {
                    ctx.Meetings.Add(meeting);
                    ctx.SaveChanges();
                }
            }
            catch(SqlException ex)
            {
            }
            catch (Exception ex)
            {
            }          
        }

        public void ModifyMeeting(Meeting updatedmeeting)
        {
            using (ManagementMeetingsEntities ctx = new ManagementMeetingsEntities())
            {
                ctx.Meetings.Add(updatedmeeting);
                ctx.Entry(updatedmeeting).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        #endregion
    }
}