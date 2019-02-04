using Microsoft.AspNetCore.Mvc;
using System;

namespace WebAPITemplate.Controllers
{
    [Route("api/[controller]")]
    public class PingController : Controller
    {
        [HttpGet()]
        public IActionResult Ping()
        {
            return Ok(DateTime.Now.ToString());
        }
    }
}