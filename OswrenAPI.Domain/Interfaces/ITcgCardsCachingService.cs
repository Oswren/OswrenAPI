using OswrenAPI.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OswrenAPI.Domain.Interfaces
{
    public interface ITcgCardsCachingService
    {
        public void AddToCache(List<TcgCard> setTcgCards);
        public Task<List<TcgCard>> GetCachedCardsIfPresent(string set);
    }
}
