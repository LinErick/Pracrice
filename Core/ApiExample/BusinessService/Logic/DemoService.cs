using BusinessService.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Logic
{
    public class DemoService: IDemoService
    {
        private readonly IModuleService moduleService;
        public DemoService(IModuleService moduleService)
        {
            this.moduleService = moduleService;
        }

        public IEnumerable<T> Get<T>()
        {
            return moduleService.Get<T>();
        }
        public void Add(Request.DemoAdd demoAdd)
        {
            moduleService.Add(demoAdd);
        }
        public void Update(Request.DemoUpdate demoUpdate)
        {
            moduleService.Update(demoUpdate);
        }
        public void Delete(Request.DemoDelete demoDelete)
        {
            moduleService.Delete(demoDelete);
        }
    }
}
