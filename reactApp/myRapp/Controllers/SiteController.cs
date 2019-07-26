using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myRapp.Models;

namespace myRapp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SiteController : Controller
    {
        private readonly SiteContext _siteContext;
        private readonly ILogger<SiteController> _logger;


        public SiteController(ILogger<SiteController> logger, SiteContext siteContext)
        {
            _logger = logger;
            _siteContext = siteContext;
        }

        [HttpGet]
        public async Task Get()
        {
            _siteContext.Sites.Add(new Site { Url = "localhost" });
            await _siteContext.SaveChangesAsync();
        }

        [HttpGet]
        [Route("[action]")]
        public JsonResult Clean()
        {
            //_siteContext.Sites.Add(new Site { Url = "localhost" });
            //await _siteContext.SaveChangesAsync();
            return Json(new { name = "test" });
        }
    }
}
