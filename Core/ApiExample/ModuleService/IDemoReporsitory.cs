using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleService
{
    public interface IDemoReporsitory
    {
        public IEnumerable<T> Select<T>(string selectSyntax);
        public void Insert(BusinessService.Request.DemoAdd demoAdd);
        public void Update(BusinessService.Request.DemoUpdate demoUpdate);
        public void Delete(BusinessService.Request.DemoDelete demoDelete);
    }
}
