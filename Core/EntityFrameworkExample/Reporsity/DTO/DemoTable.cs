using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporsity.DTO
{
    [Table("ef.DemoTable")]
    public class DemoTable
    {
        [Key]
        public int SN { set; get; }
        public DateTime CreateDate { set; get; }
        public DateTime? UpdateDate { set; get; }
        public string Comment { set; get; }

        public List<DemoTableDetail> Detail { set; get; }
    }
}
