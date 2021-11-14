using BusinessService.Request;
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

        public void Delete(DemoDelete demoDelete)
        {
            sqlConnection.Execute(@"Delete Demo Where SN=@SN", demoDelete);
        }

        public void Insert(DemoAdd demoAdd)
        {
            sqlConnection.Execute(@"Insert Demo([Date],[Commit])
                                    Values(GETDATE(), @Commit)", demoAdd);
        }

        public IEnumerable<T> Select<T>(string SelectSyntax)
        {
            return sqlConnection.Query<T>(SelectSyntax);
        }

        public void Update(DemoUpdate demoUpdate)
        {
            string sql = @"Update Demo
                            Set [Commit]=@Commit
                            Where SN=@SN";

            if (sqlConnection.Execute(sql, demoUpdate) == 0)
                throw new ArgumentException("No Data Update","Update");
        }
    }
}
