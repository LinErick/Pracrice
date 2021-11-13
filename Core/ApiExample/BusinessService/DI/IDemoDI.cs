using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.DI
{
    public interface IDemoDI
    {
        public IEnumerable<string> Get();
        public IEnumerable<string> Get(string id);
        public IEnumerable<string> Get(string id,string title);
    }
}
