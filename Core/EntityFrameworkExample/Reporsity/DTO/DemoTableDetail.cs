using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporsity.DTO
{
    [Table("ef.DemoTableDetail")]
    public class DemoTableDetail
    {
        [Key]
        public int SN { set; get; }

        //[ForeignKey("SN")]
        public int DemoTableSN { set; get; }
    }
}
