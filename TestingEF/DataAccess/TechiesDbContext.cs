using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingEF.DataAccess
{
    public class TechiesDbContext:DbContext
    {
        public TechiesDbContext():base("name=TechiesDb")
        {
        }

        public TechiesDbContext(DbConnection connection)
            :base(connection,contextOwnsConnection:true)
        {
        }

        public DbSet<TechiePerson> Techies { get; set; }
    }
}
