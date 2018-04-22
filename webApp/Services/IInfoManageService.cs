using rsiProj1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Services.Protocols;

namespace rsiProj1.Services
{
    [MessageContract]
    public class MessageBox<THeader, TBody>
    {
        [MessageHeader]
        public THeader Header { get; set; }
        [MessageBodyMember]
        public TBody Body { get; set; }
    }

    [MessageContract]
    public class MessageBox<TBody>
    {
        [MessageBodyMember]
        public TBody Body { get; set; }
    }



    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IInfoManageService" in both code and config file together.
    [ServiceContract]
    public interface IInfoManageService
    {
        [OperationContract]
        MessageBox<Guid> AddEvent(MessageBox<AdminHeader, EventAddViewModel> message);

        [OperationContract]
        MessageBox<Guid> EditEvent(MessageBox<AdminHeader, EventEditViewModel> message);

        [OperationContract]
        MessageBox<bool> RemoveEvent(MessageBox<AdminHeader, Guid> message);
    }
}
