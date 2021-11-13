using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessService.Dto
{
    [Table("Demo")]
    public class Demo
    {
        public int SN { set; get; }
        public DateTime Date { set; get; }
        public String Commit { set; get; }
    }
}
