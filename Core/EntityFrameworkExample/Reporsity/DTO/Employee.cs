using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporsity.DTO
{
    [Table("ef.Employee")]
    public class Employee
    {
        [Key]
        public int SN { set; get; }
        public string Name { set; get; }
    }
}
