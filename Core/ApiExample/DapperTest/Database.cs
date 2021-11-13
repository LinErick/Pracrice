using Dapper;
using ModuleService;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTest
{
    public class Database: IDemoReporsitory
    {
        SqlConnection sqlConnection;

        public Database()
        {
            sqlConnection = new SqlConnection("Data Source =.\\SQLExpress; Initial Catalog = TESTDB; Integrated Security = False; uid = sa; password = 123456");
        }
        public IEnumerable<T> Select<T>(string SelectSyntax)
        {
            //using var connect = new SqlConnection(@"Data Source =DESKTOP-F0PUC0R\SQLEXPRESS; Initial Catalog = TESTDB; Integrated Security = False; uid = sa; password = 123456");
            return sqlConnection.Query<T>(SelectSyntax);
        }

        public IEnumerable<T> Select<T>(string selectSyntax, SqlParameter[] sqlParameter)
        {
            throw new NotImplementedException();
        }
    }
}
