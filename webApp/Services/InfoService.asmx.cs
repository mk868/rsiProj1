using AutoMapper;
using rsiProj1.Extensions;
using rsiProj1.Utils.DateTimeUtils;
using rsiProj1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace rsiProj1
{
    /// <summary>
    /// Summary description for InfoService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class InfoService : System.Web.Services.WebService
    {
        private DataContext _dataContext;

        public InfoService()
        {
            _dataContext = new DataContext(); // TODO DI
        }

        [WebMethod]
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


        [WebMethod]
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

        [WebMethod]
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

        [WebMethod]
        public Guid AddEvent(EventAddViewModel model)
        {
            if (String.IsNullOrEmpty(model.Name))
            {
                throw new ArgumentException("Name not set!");
            }

            if (!DateTime.TryParse(model.Date, out DateTime date))
            {
                throw new ArgumentException("Date not valid!");
            }

            var type = _dataContext
                .Types
                .FirstOrDefault(t => t.Name == model.TypeName);

            if (type == null)
            {
                throw new ArgumentException("Type not exist!");
            }

            var _event = new Models.Event
            {
                Name = model.Name,
                Date = date,
                Description = model.Description,
                Type = type
            };

            _dataContext.Events.Add(_event);
            _dataContext.SaveChanges();

            return _event.Id;
        }

        [WebMethod]
        public Guid EditEvent(EventEditViewModel model)
        {
            var _event = _dataContext
                .Events
                .FirstOrDefault(e => e.Id == model.Id);

            if (_event == null)
            {
                throw new ArgumentException("Event not exist");
            }

            if (String.IsNullOrEmpty(model.Name))
            {
                throw new ArgumentException("Name not set!");
            }

            if (!DateTime.TryParse(model.Date, out DateTime date))
            {
                throw new ArgumentException("Date not valid!");
            }

            var type = _dataContext
                .Types
                .FirstOrDefault(t => t.Name == model.TypeName);

            if (type == null)
            {
                throw new ArgumentException("Type not exist!");
            }

            _event.Name = model.Name;
            _event.Date = date;
            _event.Description = model.Description;
            _event.Type = type;

            _dataContext.SaveChanges();

            return _event.Id;
        }

        [WebMethod]
        public bool RemoveEvent(Guid id)
        {
            var _event = _dataContext
                .Events
                .FirstOrDefault(e => e.Id == id);

            if (_event == null)
            {
                throw new ArgumentException("Event not exist");
            }

            _dataContext.Events.Remove(_event);
            _dataContext.SaveChanges();

            return true;
        }

        [WebMethod]
        public string HelloWorld()
        {
            _dataContext.SaveChangesAsync();
            return "Hello World";
        }
    }
}
