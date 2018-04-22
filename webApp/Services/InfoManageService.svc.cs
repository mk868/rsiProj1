using rsiProj1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace rsiProj1.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "InfoManageService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select InfoManageService.svc or InfoManageService.svc.cs at the Solution Explorer and start debugging.
    public class InfoManageService : IInfoManageService
    {
        public const string Password = "abc";

        private DataContext _dataContext;

        public InfoManageService()
        {
            _dataContext = new DataContext(); // TODO DI
        }


        private bool CheckAuth(AdminHeader adminHeader)
        {
            return adminHeader.Password == Password;
        }

        public MessageBox<Guid> AddEvent(MessageBox<AdminHeader, EventAddViewModel> message)
        {
            if (!CheckAuth(message.Header))
            {
                throw new Exception("wrong password!");
            }

            if (String.IsNullOrEmpty(message.Body.Name))
            {
                throw new ArgumentException("Name not set!");
            }

            if (!DateTime.TryParse(message.Body.Date, out DateTime date))
            {
                throw new ArgumentException("Date not valid!");
            }

            var type = _dataContext
                .Types
                .FirstOrDefault(t => t.Name == message.Body.TypeName);

            if (type == null)
            {
                throw new ArgumentException("Type not exist!");
            }

            var _event = new Models.Event
            {
                Name = message.Body.Name,
                Date = date,
                Description = message.Body.Description,
                Type = type
            };

            _dataContext.Events.Add(_event);
            _dataContext.SaveChanges();

            return new MessageBox<Guid> { Body = _event.Id };
        }

        public MessageBox<Guid> EditEvent(MessageBox<AdminHeader, EventEditViewModel> message)
        {
            if (!CheckAuth(message.Header))
            {
                throw new Exception("wrong password!");
            }

            var _event = _dataContext
                .Events
                .FirstOrDefault(e => e.Id == message.Body.Id);

            if (_event == null)
            {
                throw new ArgumentException("Event not exist");
            }

            if (String.IsNullOrEmpty(message.Body.Name))
            {
                throw new ArgumentException("Name not set!");
            }

            if (!DateTime.TryParse(message.Body.Date, out DateTime date))
            {
                throw new ArgumentException("Date not valid!");
            }

            var type = _dataContext
                .Types
                .FirstOrDefault(t => t.Name == message.Body.TypeName);

            if (type == null)
            {
                throw new ArgumentException("Type not exist!");
            }

            _event.Name = message.Body.Name;
            _event.Date = date;
            _event.Description = message.Body.Description;
            _event.Type = type;

            _dataContext.SaveChanges();

            return new MessageBox<Guid> { Body = _event.Id };
        }




        public MessageBox<bool> RemoveEvent(MessageBox<AdminHeader, Guid> message)
        {
            if (!CheckAuth(message.Header))
            {
                throw new Exception("wrong password!");
            }

            var _event = _dataContext
                .Events
                .FirstOrDefault(e => e.Id == message.Body);

            if (_event == null)
            {
                throw new ArgumentException("Event not exist");
            }

            _dataContext.Events.Remove(_event);
            _dataContext.SaveChanges();

            return new MessageBox<bool> { Body = true };
        }
    }
}
