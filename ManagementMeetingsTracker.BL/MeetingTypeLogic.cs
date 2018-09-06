using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ManagementMeetingsTracker.BE;

namespace ManagementMeetingsTracker.BL
{
    public class MeetingTypeLogic
    {
        #region Read Methods

        public List<MeetingType> GetAllMeettingTypes()
        {
            using (ManagementMeetingsEntities ctx = new ManagementMeetingsEntities())
            {
                return ctx.MeetingTypes.ToList();
            }
        }

        public MeetingType GetMeettingType(int MeetingTypeId)
        {
            using (ManagementMeetingsEntities ctx = new ManagementMeetingsEntities())
            {
                return ctx.MeetingTypes.SingleOrDefault(x => x.MeetingTypeId == MeetingTypeId);
            }
        }

        public static string GetMeetingTypeDescription(int MeetingTypeId)
        {
            using (ManagementMeetingsEntities ctx = new ManagementMeetingsEntities())
            {
                return ctx.MeetingTypes.SingleOrDefault(x => x.MeetingTypeId == MeetingTypeId).MeetingType1;
            }
        }

        #endregion

        #region Modify Methods

        public void AddMeetingType(MeetingType meeting)
        {
            try
            {
                using (ManagementMeetingsEntities ctx = new ManagementMeetingsEntities())
                {
                    ctx.MeetingTypes.Add(meeting);
                    ctx.SaveChanges();
                }
            }
            catch (SqlException ex)
            {

            }
            catch(Exception ex)
            {

            }
        }

        public void ModifyMeetingType(MeetingType updatedMeetingType)
        {
            using (ManagementMeetingsEntities ctx = new ManagementMeetingsEntities())
            {
                ctx.MeetingTypes.Add(updatedMeetingType);
                ctx.Entry(updatedMeetingType).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }              

        #endregion
    }
}