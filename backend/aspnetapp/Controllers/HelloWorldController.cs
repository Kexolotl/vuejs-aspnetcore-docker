using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace aspnetapp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HelloWorldController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(new HelloWorldResponse {
                Message = "Hello Friends"
            });
        }

        public class HelloWorldResponse 
        {
            public string Message {get; set;}
        }
    }
}