using OswrenAPI.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OswrenAPI.Domain.Interfaces
{
    public interface ITradingCardService
    {
        public Task<IEnumerable<TcgSet>> GetTcgSets();
    }
}
