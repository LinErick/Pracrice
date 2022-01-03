using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExample.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DemoDIController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly DemoSettingDI demoSettingDI;
        public DemoDIController(IConfiguration configuration, DemoSettingDI demoSettingDI)
        {
            this.configuration = configuration;
            this.demoSettingDI = demoSettingDI;
        }

        [HttpGet]
        public IActionResult GetIConfiguration()
        {
            return Ok(configuration.GetValue<string>("AppSettings:Secret"));
        }

        [HttpGet]
        public IActionResult GetDemoSettingDI()
        {
            return Ok(demoSettingDI);
        }
    }
}
