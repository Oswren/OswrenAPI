using OswrenAPI.Domain.Interfaces;
using OswrenAPI.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OswrenAPI.Domain.Services
{
    public class TradingCardService : ITradingCardService
    {
        private readonly ITcgReader _tcgBroker;

        public TradingCardService(ITcgReader tcgBroker)
        {
            _tcgBroker = tcgBroker;
        }

        public async Task<IEnumerable<TcgSet>> GetTcgSetsAsync()
        {
            return await _tcgBroker.GetSetlistAsync();
        }

        public async Task<IEnumerable<TcgCard>> GetTcgCardsBySetAsync(string set)
        {
            return await _tcgBroker.GetMTGCardListAsync(set);
        }
    }
}
