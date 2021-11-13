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
        [Range(1,99999,ErrorMessage = "參數 SN 範圍錯誤。")]
        public int SN { set; get; }
        [Required]
        public string Commit { set; get; }
    }
}
