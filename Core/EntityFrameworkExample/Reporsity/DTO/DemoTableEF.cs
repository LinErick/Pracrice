using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.DTO
{
    [Table("DemoTableEF")]
    public class DemoTableEF
    {
        [Key]
        public int SN { set; get; }
        public DateTime CreateDate { set; get; }
        public DateTime? UpdateDate { set; get; } = null;
        public string Comment { set; get; } 
    }
}
