using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.DI
{
    public class DemoDI: IDemoDI
    {
        public DemoDI()
        {

        }

        public IEnumerable<string> Get()
        {
            return new List<string>() { "Test_ConfigureServices"};
        }

        public IEnumerable<string> Get(string id)
        {
            return new List<string>() { "id" };
        }

        public IEnumerable<string> Get(string id, string title)
        {
            return new List<string>() { "id&title" };
        }
    }
}
