using BusinessService.DI;
using BusinessService.Dto;
using BusinessService.Logic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlConnect.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DemoController : ControllerBase
    {
        readonly IDemoDI logic;
        readonly IModuleService moduleService;
        public DemoController(IDemoDI logic,IModuleService moduleService)
        {
            this.logic = logic;
            this.moduleService = moduleService;
        }

        
        [HttpGet]
        [Route("[controller]")]
        public ActionResult Index()
        {
            return Ok(logic.Get());
        }

        [HttpGet]
        [Route("[controller]/{id}/{title}")]
        public ActionResult Get(string id,string title)
        {
            return Ok(logic.Get(id, title));
        }

        [HttpGet]
        public ActionResult GetSql()
        {
            DemoService demo = new(moduleService);
            IEnumerable<Demo> result = demo.Get<Demo>();
            return Ok(result);
        }

        [HttpPost]
        public ActionResult InsertSql()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult DeleteSql()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult UpdateSql()
        {
            return Ok();
        }
    }
}
