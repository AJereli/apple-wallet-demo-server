using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppleWalletServerDemo.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
       

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Thrive Apple Wallet Demo Server";
        }
    }
}