using OswrenAPI.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OswrenAPI.Domain.Interfaces
{
    public interface IBoosterPackService
    {
        public Task<IEnumerable<TcgCard>> GetBoosterPackForSetAsync(string set);
    }
}
