using AutoMapper;
using iTextSharp.text;
using iTextSharp.text.pdf;
using rsiProj1.Utils.DateTimeUtils;
using rsiProj1.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace rsiProj1.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "InfoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select InfoService.svc or InfoService.svc.cs at the Solution Explorer and start debugging.
    public class InfoService : IInfoService
    {

        private DataContext _dataContext;

        public InfoService()
        {
            _dataContext = new DataContext(); // TODO DI
        }

        public EventViewModel GetEventById(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException(nameof(id), "Id not set!");
            }

            if (!Guid.TryParse(id, out Guid guidId))
            {
                throw new ArgumentException("Id not correct", nameof(id));
            }

            var _event = _dataContext
                .Events
                .FirstOrDefault(e => e.Id == guidId);

            return Mapper.Map<EventViewModel>(_event);
        }

        public List<EventListItemViewModel> GetEventsForDay(string date)
        {
            var dateParsed = DateTime.Parse(date);

            var events = _dataContext
                .Events
                .Where(e => e.Date.Year == dateParsed.Year)
                .Where(e => e.Date.Month == dateParsed.Month)
                .Where(e => e.Date.Day == dateParsed.Day)
                .ToList();

            return Mapper.Map<List<EventListItemViewModel>>(events);
        }

        public List<EventListItemViewModel> GetEventsForWeek(int week, int? year)
        {
            if (!year.HasValue)
            {
                year = DateTime.Now.Year;
            }

            var startDate = DateTimeUtils.FirstDateOfWeekISO8601(year.Value, week);
            var endDate = startDate.AddDays(7); //.AddMilliseconds(-1);

            var events = _dataContext
                .Events
                .Where(e => e.Date >= startDate)
                .Where(e => e.Date < endDate)
                .ToList();

            return Mapper.Map<List<EventListItemViewModel>>(events);
        }

        private byte[] GeneratePdf(string text, List<EventListItemViewModel> events)
        {
            Document doc = new Document();
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);
            doc.Open();
            doc.Add(new Paragraph(text, new Font(Font.FontFamily.TIMES_ROMAN, 20)));

            foreach (var ev in events)
            {
                doc.Add(new Paragraph(ev.Name, new Font(Font.FontFamily.TIMES_ROMAN, 16))
                {
                    IndentationLeft = 0
                });
                doc.Add(new Paragraph("Date: " + ev.Date.ToString(), new Font(Font.FontFamily.TIMES_ROMAN, 12))
                {
                    IndentationLeft = 15
                });
            }

            writer.CloseStream = false;
            doc.Close();
            memoryStream.Position = 0;

            return memoryStream.ToArray();
        }

        public byte[] GetPdfSummaryForDay(string date)
        {
            var events = this.GetEventsForDay(date);

            return GeneratePdf($"Summary for: {date}", events);
        }

        public byte[] GetPdfSummaryForWeek(int week, int? year)
        {
            var events = this.GetEventsForWeek(week, year);

            return GeneratePdf($"Summary for week: {week} of {year ?? DateTime.Now.Year}", events);
        }
    }
}
