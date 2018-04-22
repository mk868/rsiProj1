using rsiProj1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace rsiProj1.Services
{
    [ServiceContract]
    public interface IInfoService
    {
        [OperationContract]
        EventViewModel GetEventById(string id);

        [OperationContract]
        List<EventListItemViewModel> GetEventsForDay(string date);

        [OperationContract]
        List<EventListItemViewModel> GetEventsForWeek(int week, int? year);

        [OperationContract]
        byte[] GetPdfSummaryForDay(string date);

        [OperationContract]
        byte[] GetPdfSummaryForWeek(int week, int? year);
    }
}
