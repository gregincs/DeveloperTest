using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api2.Controllers
{
    [Route("showmethecode")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        // GET: /showmethecode
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "https://github.com/gregincs/DeveloperTest";
        }
    }
}
