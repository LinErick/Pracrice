using EFTest.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporsity
{
    public class NewTableContext:DbContext
    {
        public NewTableContext():base("Data Source =.\\SQLExpress; Initial Catalog = TESTDB; Integrated Security = False; uid = sa; password = 123456")
        {

        }
        public DbSet<DemoTableEF> DemoTableEFs { get; set; }
    }
}
