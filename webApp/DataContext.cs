using rsiProj1.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace rsiProj1
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Type> Types { get; set; }
    }
}