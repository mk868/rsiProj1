using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rsiProj1.ViewModels
{
    public class EventViewModel
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }
        public int WeekOfYear { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Guid TypeId { get; set; }
        public string TypeName { get; set; }
    }
}