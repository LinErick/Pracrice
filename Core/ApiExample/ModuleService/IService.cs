using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleService
{
    public interface IService
    {
        public IEnumerable<T> Select<T>();
    }
}
