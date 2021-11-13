using BusinessService.Logic;
using BusinessService.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleService.Table
{
    public class DemoModuleService: IModuleService
    {
        readonly IDemoReporsitory database;
        public DemoModuleService(IDemoReporsitory database)
        {
            this.database = database;
        }

        public void Add(DemoAdd demoAdd)
        {
            database.Insert(demoAdd);
        }

        public void Delete(DemoDelete demoDelete)
        {
            database.Delete(demoDelete);
        }

        public IEnumerable<T> Get<T>()
        {
            return database.Select<T>("Select Top 10 * From Demo");
        }

        public void Update(DemoUpdate demoUpdate)
        {
            database.Update(demoUpdate);
        }
    }
}
