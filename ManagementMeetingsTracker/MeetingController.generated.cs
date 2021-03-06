// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace ManagementMeetingsTracker.Controllers
{
    public partial class MeetingController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public MeetingController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected MeetingController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> GetMeeting()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetMeeting);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SaveMeeting()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SaveMeeting);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.FileResult PrintMeetingMinutes()
        {
            return new T4MVC_System_Web_Mvc_FileResult(Area, Name, ActionNames.PrintMeetingMinutes);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public MeetingController Actions { get { return MVC.Meeting; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Meeting";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Meeting";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string GetMeeting = "GetMeeting";
            public readonly string GetAddMeeting = "GetAddMeeting";
            public readonly string SaveMeeting = "SaveMeeting";
            public readonly string PrintMeetingMinutes = "PrintMeetingMinutes";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string GetMeeting = "GetMeeting";
            public const string GetAddMeeting = "GetAddMeeting";
            public const string SaveMeeting = "SaveMeeting";
            public const string PrintMeetingMinutes = "PrintMeetingMinutes";
        }


        static readonly ActionParamsClass_GetMeeting s_params_GetMeeting = new ActionParamsClass_GetMeeting();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetMeeting GetMeetingParams { get { return s_params_GetMeeting; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetMeeting
        {
            public readonly string MeetingId = "MeetingId";
        }
        static readonly ActionParamsClass_SaveMeeting s_params_SaveMeeting = new ActionParamsClass_SaveMeeting();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SaveMeeting SaveMeetingParams { get { return s_params_SaveMeeting; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SaveMeeting
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_PrintMeetingMinutes s_params_PrintMeetingMinutes = new ActionParamsClass_PrintMeetingMinutes();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_PrintMeetingMinutes PrintMeetingMinutesParams { get { return s_params_PrintMeetingMinutes; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_PrintMeetingMinutes
        {
            public readonly string MeetingId = "MeetingId";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string GetAddMeeting = "GetAddMeeting";
                public readonly string GetAllMeetings = "GetAllMeetings";
                public readonly string GetMeeting = "GetMeeting";
            }
            public readonly string GetAddMeeting = "~/Views/Meeting/GetAddMeeting.cshtml";
            public readonly string GetAllMeetings = "~/Views/Meeting/GetAllMeetings.cshtml";
            public readonly string GetMeeting = "~/Views/Meeting/GetMeeting.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_MeetingController : ManagementMeetingsTracker.Controllers.MeetingController
    {
        public T4MVC_MeetingController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void GetMeetingOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int MeetingId);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> GetMeeting(int MeetingId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetMeeting);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "MeetingId", MeetingId);
            GetMeetingOverride(callInfo, MeetingId);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void GetAddMeetingOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> GetAddMeeting()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetAddMeeting);
            GetAddMeetingOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void SaveMeetingOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, ManagementMeetingsTracker.Models.MeetingModel model);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SaveMeeting(ManagementMeetingsTracker.Models.MeetingModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SaveMeeting);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            SaveMeetingOverride(callInfo, model);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void PrintMeetingMinutesOverride(T4MVC_System_Web_Mvc_FileResult callInfo, int MeetingId);

        [NonAction]
        public override System.Web.Mvc.FileResult PrintMeetingMinutes(int MeetingId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_FileResult(Area, Name, ActionNames.PrintMeetingMinutes);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "MeetingId", MeetingId);
            PrintMeetingMinutesOverride(callInfo, MeetingId);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
