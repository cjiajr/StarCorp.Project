using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarCorp.Project.Application;


namespace StarCorp.Project.Manager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        private readonly IStarCorpProjectApplication _starCorpProjectApplication;
        
        public CalculateController(IStarCorpProjectApplication starCorpProjectApplication)
        {
            _starCorpProjectApplication = starCorpProjectApplication;
        }

        // GET api/calculate/5
        [HttpGet("{Number}")]
        public ActionResult<string> Get(int Number)
        {
            return _starCorpProjectApplication.Calculate(Number);
        }
    }
}
