using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OswrenAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MTGController : ControllerBase
    {
        private readonly ILogger<MTGController> _logger;

        public MTGController(ILogger<MTGController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
        }
    }
}
