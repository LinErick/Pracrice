using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Logic
{
    public class DemoService
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
    }
}
