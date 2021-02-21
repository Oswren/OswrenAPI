using OswrenAPI.Domain.Interfaces;
using OswrenAPI.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OswrenAPI.Domain.Services
{
    public class TradingCardService : ITradingCardService
    {
        public ITcgReader _tcgBroker;

        public TradingCardService(ITcgReader tcgBroker)
        {
            _tcgBroker = tcgBroker;
        }

        public async Task<IEnumerable<TcgSet>> GetTcgSets()
        {
            return await _tcgBroker.GetSetlist();
        }

        public async Task<IEnumerable<TcgCard>> GetTcgCardsBySet(string set)
        {
            return await _tcgBroker.GetMTGCardList(set);
        }
    }
}
