using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace rsiProj1.Models
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public virtual Guid TypeId { get; set; }
        public virtual Type Type { get; set; }

        public Event()
        {
            Id = Guid.NewGuid();
        }
    }
}