using EFTest.DTO;
using Reporsity;
using System;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sql = new NewTableContext();

            //Insert
            var insertData = new DemoTableEF { CreateDate = DateTime.Now, Comment = "TestEF" };
            sql.DemoTableEFs.Add(insertData);
            sql.SaveChanges();

            //Select
            var selectData = sql.DemoTableEFs.Find(3);
            if (selectData != null)
            {
                Console.WriteLine(string.Format("{0} {1} {2}", selectData.SN, selectData.CreateDate, selectData.Comment));

                //Update
                sql.DemoTableEFs.Attach(selectData);
                selectData.UpdateDate = DateTime.Now;
                sql.SaveChanges();
            }

            //Delete
            var deleteData = sql.DemoTableEFs.Find(1);
            if (deleteData != null)
            {
                sql.DemoTableEFs.Remove(deleteData);
                sql.SaveChanges();
            }
        }
    }
  

}
