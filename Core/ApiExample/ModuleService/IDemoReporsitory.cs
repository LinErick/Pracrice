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
    }
}
