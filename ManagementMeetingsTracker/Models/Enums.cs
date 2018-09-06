using System.ComponentModel.DataAnnotations;
using ManagementMeetingsTracker.Resources;

namespace ManagementMeetingsTracker.Models
{
    public enum MeetingType
    {
        [Display(Name = "MANCO", ResourceType = typeof(Labels))]
        MANCO,
        [Display(Name = "FINANCE", ResourceType = typeof(Labels))]
        FINANCE,
        [Display(Name = "PROJECTTEAMLEADERS", ResourceType = typeof(Labels))]
        PROJECTTEAMLEADERS
    }

    public enum MeetingStatus
    {
        Open,
        InDevelopment,
        AwaitingInvoicing,
        Closed
    }
}