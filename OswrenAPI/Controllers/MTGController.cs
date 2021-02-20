using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OswrenAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OswrenAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MTGController : ControllerBase
    {
        private readonly ILogger<MTGController> _logger;
        private readonly IBoosterPackService _boosterService;

        public MTGController(ILogger<MTGController> logger, IBoosterPackService boosterService)
        {
            _logger = logger;
            _boosterService = boosterService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> Get()
        {
            try
            {
                return Ok(await _boosterService.GetBoosterPack());
            }
            catch (Exception e)
            {
                _logger.LogWarning("Request failed when fetching sets: ", e);
                return NotFound();
            }
        }
    }
}
