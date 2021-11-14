using BusinessService.DI;
using BusinessService.Dto;
using BusinessService.Logic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SqlConnect.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DemoController : ControllerBase
    {
        readonly DemoService demoService;
        public DemoController(IModuleService moduleService)
        {
            this.demoService = new(moduleService);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("zh-TW");
        }

        [HttpGet]
        public ActionResult Get()
        {
            IEnumerable<Demo> result = demoService.Get<Demo>();

            return Ok(result);
        }

        [HttpPost]
        public ActionResult Add([FromForm] BusinessService.Request.DemoAdd demoAdd)
        {
            demoService.Add(demoAdd);

            return Ok();
        }

        [HttpPost]
        public ActionResult Delete(List<BusinessService.Request.DemoDelete> demoDeletes)
        {
            foreach (BusinessService.Request.DemoDelete demoDelete in demoDeletes)
                demoService.Delete(demoDelete);

            return Ok();
        }

        [HttpPost]
        public ActionResult Update(List<BusinessService.Request.DemoUpdate> demoUpdates)
        {
            try
            {
                foreach (BusinessService.Request.DemoUpdate demoUpdate in demoUpdates)
                    demoService.Update(demoUpdate);
            }
            catch (Exception ex)
            {
                return BadRequest(new { ex.Message });
            }

            return Ok();
        }
    }
}
