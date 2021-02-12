using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rank.Controllers
{
    [Route("api/[controller]")]
    public class TopTenController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTopTen()
        {
            return Ok(new { name = "Kalazan", rank = "3" });
        }
    }
}
