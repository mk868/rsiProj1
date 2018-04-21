using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rsiProj1.ViewModels
{
    public class EventEditViewModel
    {
        public Guid Id { get; set; }

        public string Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string TypeName { get; set; }
    }
}