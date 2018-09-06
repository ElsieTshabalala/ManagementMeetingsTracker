using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using ManagementMeetingsTracker.Resources;

namespace ManagementMeetingsTracker.Models
{
    public class MeetingModel
    {
        public int MeetingId { get; set; }

        public string MeetingCode { get; set; }

        [Display(Name = "MeetingType", ResourceType = typeof(Labels))]
        public int MeetingTypeId { get; set; }

        [Display(Name = "MeetingType", ResourceType = typeof(Labels))]
        public string MeetingType { get; set; } 

        [Display(Name = "Date", ResourceType = typeof(Labels))]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime MeetingDate { get; set; }

        [Display(Name = "Time", ResourceType = typeof(Labels))]
        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime MeetingTime { get; set; }

        public List<MeetingModel> Meetings { get; set; }       

        public List<SelectListItem> MeetingTypes { get; set; }
    }

    public class MeetingTypeModel
    {
        public int MeetingTypeId { get; set; }

        public string MeetingTypeCode { get; set; }

        public string MeetingType { get; set; }

        public string Description { get; set; }

        public List<MeetingTypeModel> MeetingTypes { get; set; }
    }

    public class MeetingItemModel
    {
        public int MeetingItemId { get; set; }

        public int MeetingId { get; set; }

        [Display(Name = "Status", ResourceType = typeof(Labels))]
        public int MeetingItemStatusId { get; set; }


        public string MeetingItemStatusDescription { get; set; }


        [Display(Name = "Description", ResourceType = typeof(Labels))]
        public string MeetingItem { get; set; }

        [Display(Name = "AssignedTo", ResourceType = typeof(Labels))]
        public string ActionBy { get; set; }

        public string Remark { get; set; }

        public List<SelectListItem> MeetingItemStatuses { get; set; }

        public List<MeetingItemModel> MeetingItems { get; set; }
    }

    public class MeetingItemStatus
    {
        public int MeetingItemStatusId { get; set; }

        public string StatusDescription { get; set; }
    }
}