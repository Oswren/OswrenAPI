using OswrenAPI.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OswrenAPI.Domain.Services
{
    public class BoosterPackService : IBoosterPackService
    {
        public ITcgReader _tcgBroker;

        public BoosterPackService(ITcgReader tcgBroker)
        {
            _tcgBroker = tcgBroker;
        }

        public async Task<IEnumerable<object>> GetBoosterPack()
        {
            return await _tcgBroker.GetSetlist();
        }
    }
}
