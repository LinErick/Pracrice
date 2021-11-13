using BusinessService.DI;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExample.Controllers
{
    public class IndexController : ControllerBase
    {
        readonly IDemoDI logic;
        public IndexController(IDemoDI logic)
        {
            this.logic = logic;
        }
        [HttpGet]
        [Route("[controller]")]
        public ActionResult Index()
        {
            return Ok(logic.Get());
        }

        [HttpGet]
        [Route("[controller]/{id}/{title}")]
        public ActionResult Get(string id, string title)
        {
            return Ok(logic.Get(id, title));
        }
    }
}
