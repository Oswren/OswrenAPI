using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OswrenAPI.Domain.Interfaces;
using OswrenAPI.Domain.Models;
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
        private readonly ITradingCardService _tradingCardService;
        private readonly IBoosterPackService _boosterPackService;

        public MTGController(ILogger<MTGController> logger, ITradingCardService tradingCardService, IBoosterPackService boosterPackService)
        {
            _logger = logger;
            _tradingCardService = tradingCardService;
            _boosterPackService = boosterPackService;
        }

        [HttpGet("sets")]
        public async Task<ActionResult<IEnumerable<TcgSet>>> GetSets()
        {
            try
            {
                return Ok(await _tradingCardService.GetTcgSets());
            }
            catch (Exception e)
            {
                _logger.LogWarning("Request failed when fetching sets: ", e);
                return BadRequest();
            }
        }

        [HttpGet("cards/{set}")]
        public async Task<ActionResult<IEnumerable<TcgSet>>> GetCardsForSet(string set)
        {
            try
            {
                return Ok(await _tradingCardService.GetTcgCardsBySet(set));
            }
            catch (Exception e)
            {
                _logger.LogWarning($"Request failed when fetching cards for set '{set}': ", e);
                return BadRequest();
            }
        }

        [HttpGet("booster/{set}")]
        public async Task<ActionResult<IEnumerable<TcgSet>>> GetBoosterPackForSet(string set)
        {
            try
            {
                return Ok(await _boosterPackService.GetBoosterPackForSet(set));
            }
            catch (Exception e)
            {
                _logger.LogWarning($"Request failed when fetching booster pack for set '{set}': ", e);
                return BadRequest();
            }
        }
    }
}
