using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Request
{
    public class DemoUpdate
    {
        [Required]
        public int SN { set; get; }
        public string Commit { set; get; }
    }
}
