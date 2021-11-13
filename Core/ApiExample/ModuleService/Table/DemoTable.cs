using BusinessService.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleService.Table
{
    public class DemoTable: IModuleService
    {
        readonly IDemoReporsitory database;
        public DemoTable(IDemoReporsitory database)
        {
            this.database = database;
        }

        public IEnumerable<T> Get<T>()
        {
            return database.Select<T>("Select Top 10 * From Demo");
        }
    }
}
