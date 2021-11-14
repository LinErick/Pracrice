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
        [Range(1, 2147483647, ErrorMessageResourceType = (typeof(Resource.DemoResource)), ErrorMessageResourceName = "TestResource")]
        public int SN { set; get; }
        [Required(AllowEmptyStrings = true)]
        public string Commit { set; get; }
    }
}
