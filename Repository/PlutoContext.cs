using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Model;

namespace Repository
{
    public class PlutoContext : DbContext
    {
        public PlutoContext()
            : base("DbConnection")
        {

        }

        public DbSet<Course> Courses { get; }
        public DbSet<Author> Authors { get; set; }
    }
}
