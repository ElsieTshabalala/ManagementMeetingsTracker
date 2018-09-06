using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ManagementMeetingsTracker.BE;
using ManagementMeetingsTracker.BL;
using ManagementMeetingsTracker.Models;

namespace ManagementMeetingsTracker.Controllers
{
    public partial class MeetingController : Controller
    {        
        [HttpGet]
        public virtual async Task<ActionResult> Index()
        {
            MeetingModel model = new MeetingModel();
         
            MeetingLogic mLogic = new MeetingLogic();

            MeetingTypeLogic mtLogic = new MeetingTypeLogic();

            var meetings = (from m in mLogic.GetAllMeettings()
                           select new MeetingModel
                           {
                               MeetingId = m.MeetingId,
                               MeetingDate = m.StartDate,
                               MeetingTypeId = m.MeetingTypeId,
                               MeetingTime = m.StartDate,
                               MeetingCode = string.Format("{0}{1}", MeetingTypeLogic.GetMeetingTypeDescription(m.MeetingTypeId)[0], m.MeetingId),
                               MeetingType = MeetingTypeLogic.GetMeetingTypeDescription(m.MeetingTypeId)
                           }).ToList();

            model.Meetings = meetings;

            return View(MVC.Meeting.Views.GetAllMeetings, model);
        }

        [HttpGet]
        public virtual async Task<ActionResult> GetMeeting(int MeetingId)
        {
            MeetingModel model = new MeetingModel();

            MeetingLogic mLogic = new MeetingLogic();

            Meeting meeting = mLogic.GetMeetting(MeetingId);

            model.MeetingId = meeting.MeetingId;
            model.MeetingTypeId = meeting.MeetingTypeId;
            model.MeetingDate = meeting.StartDate;
            model.MeetingTime = meeting.StartDate;
            model.MeetingType = MeetingTypeLogic.GetMeetingTypeDescription(meeting.MeetingTypeId);

            return View(MVC.Meeting.Views.GetMeeting, model);
        }

        [HttpGet]
        public virtual async Task<ActionResult> GetAddMeeting()
        {
            MeetingModel model = new MeetingModel();

            MeetingTypeLogic mtLogic = new MeetingTypeLogic();

            var meetingTypes = mtLogic.GetAllMeettingTypes();

            model.MeetingTypes = (from x in meetingTypes
                                  select new SelectListItem
                                  {
                                      Text = x.MeetingType1,
                                      Value = x.MeetingTypeId.ToString()
                                  }).ToList();

            return View(MVC.Meeting.Views.GetAddMeeting, model);
        }
        
        
        [HttpPost]
        public virtual async Task<ActionResult> SaveMeeting(MeetingModel model)
        {
            Meeting meeting = new Meeting();

            // TODO: Setting meeting values from model values 
            meeting.MeetingTypeId = model.MeetingTypeId;

            DateTime startDate = model.MeetingDate.Date;
            TimeSpan startTime = model.MeetingTime.TimeOfDay;

            DateTime result = startDate + startTime;

            meeting.StartDate = result;            

            MeetingLogic ml = new MeetingLogic();
            ml.AddMeeting(meeting);

            return RedirectToAction(MVC.Meeting.Index());
        }

        public virtual FileResult PrintMeetingMinutes(int MeetingId)
        {
            MemoryStream workStream = new MemoryStream();
            StringBuilder status = new StringBuilder("");
            DateTime dTime = DateTime.Now;

            MeetingLogic mLogic = new MeetingLogic();
            Meeting meeting = mLogic.GetMeetting(MeetingId);

            //file name to be created           
            string strPDFFileName = string.Format("Meeting-" + meeting.StartDate.ToString("yyyyMMdd") + "-" + meeting.MeetingId + "-" + meeting.MeetingTypeId + ".pdf");

            Document doc = new Document();
            doc.SetMargins(0f, 0f, 0f, 0f);

            //Create PDF Table with 5 columns
            PdfPTable tableLayout = new PdfPTable(4);
            doc.SetMargins(0f, 0f, 0f, 0f);

            //Create PDF Table

            //file will created in this path
            string strAttachment = Server.MapPath("~/Downloadss/" + strPDFFileName);

            PdfWriter.GetInstance(doc, workStream).CloseStream = false;
            doc.Open();

            //Add Content to PDF 
            doc.Add(Add_Content_To_PDF(MeetingId, tableLayout));

            // Closing the document
            doc.Close();

            byte[] byteInfo = workStream.ToArray();
            workStream.Write(byteInfo, 0, byteInfo.Length);
            workStream.Position = 0;

            return File(workStream, "application/pdf", strPDFFileName);
        }

        #region Pdf Generation Helper

        protected PdfPTable Add_Content_To_PDF(int MeetingId, PdfPTable tableLayout)
        {          
            MeetingItemLogic miLogic = new MeetingItemLogic();

            float[] headers = { 50, 24, 45, 35 };  //Header Widths

            tableLayout.SetWidths(headers);            //Set the pdf headers
            tableLayout.WidthPercentage = 100;         //Set the PDF File witdh percentage
            tableLayout.HeaderRows = 1;

            //Add Title to the PDF file at the top            

            List<MeetingItem> meetingItems = miLogic.GetAllMeettingItems(MeetingId);

            tableLayout.AddCell(new PdfPCell(new Phrase("Meeting Items", 
                                new Font(Font.FontFamily.HELVETICA, 8, 1, new iTextSharp.text.BaseColor(0, 0, 0))))
                                { Colspan = 12, Border = 0, PaddingBottom = 5, HorizontalAlignment = Element.ALIGN_CENTER });

            ////Add header
            AddCellToHeader(tableLayout, "Meeting Item");
            AddCellToHeader(tableLayout, "Comment");
            AddCellToHeader(tableLayout, "Status");
            AddCellToHeader(tableLayout, "Action By");

            ////Add body                       
            foreach (var meetingItem in meetingItems)
            {
                AddCellToBody(tableLayout, meetingItem.MeetingItem1);
                AddCellToBody(tableLayout, meetingItem.Remark);
                AddCellToBody(tableLayout, meetingItem.MeetingItemStatusId.ToString());
                AddCellToBody(tableLayout, meetingItem.ActionBy);
            }

            return tableLayout;
        }

        // Method to add single cell to the Header
        private static void AddCellToHeader(PdfPTable tableLayout, string cellText)
        {
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, new Font(Font.FontFamily.HELVETICA, 8, 1, BaseColor.YELLOW))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new iTextSharp.text.BaseColor(128, 0, 0) });
        }

        // Method to add single cell to the body
        private static void AddCellToBody(PdfPTable tableLayout, string cellText)
        {
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, new Font(Font.FontFamily.HELVETICA, 8, 1, BaseColor.BLACK))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255) });
        }

        #endregion
    }
}