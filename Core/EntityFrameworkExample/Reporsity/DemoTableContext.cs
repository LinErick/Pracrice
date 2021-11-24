using Reporsity.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporsity
{

    [DbConfigurationType(typeof(Configuration))]
    public class DemoTableContext:DbContext
    {
        public DemoTableContext():base("Data Source =.\\SQLExpress; Initial Catalog = TESTDB2; Integrated Security = False; uid = sa; password = 123456")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DemoTableContext>(null);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<DemoTable> DemoTableEFs { get; set; }
        public DbSet<DemoTableDetail> DemoTableDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
