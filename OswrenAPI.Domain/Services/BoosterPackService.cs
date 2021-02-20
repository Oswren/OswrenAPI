using OswrenAPI.Domain.Interfaces;

namespace OswrenAPI.Domain.Services
{
    public class BoosterPackService : IBoosterPackService
    {
        public ITcgReader _tcgBroker;

        public BoosterPackService(ITcgReader tcgBroker)
        {
            _tcgBroker = tcgBroker;
        }
    }
}
