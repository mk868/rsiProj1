using appClient.InfoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClient.Models
{
    public class EventListItem
    {
        public EventListItemViewModel Event { get; set; }

        public EventListItem(EventListItemViewModel _event)
        {
            Event = _event;
        }

        public override string ToString()
        {
            return this.Event.Name;
        }
    }
}
