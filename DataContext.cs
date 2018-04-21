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
            : base("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\P50\\Documents\\Visual Studio 2017\\Projects\\rsiProj1\\db.mdf\";Integrated Security=True;Connect Timeout=30")
        {
        }

        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Type> Types { get; set; }
    }
}