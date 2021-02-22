using OswrenAPI.Domain.Interfaces;
using OswrenAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OswrenAPI.Domain.Services
{
    public class TcgCardsCachingService : ITcgCardsCachingService
    {
        private readonly List<CardsCacheItem> _cardCache;

        public TcgCardsCachingService()
        {
            _cardCache = new List<CardsCacheItem>();
        }

        public void AddToCache(List<TcgCard> setTcgCards)
        {
            if (_cardCache.FirstOrDefault(x => x.Set == setTcgCards?[0].Set.ToUpperInvariant()) == null)
            {
                if(_cardCache.Count > 9)
                {
                    _cardCache.Remove(_cardCache.OrderBy(cacheItem => cacheItem.TimeAdded).ToList().First());
                }
                AddSetCardsToCache(setTcgCards);
            }
        }

        public async Task<List<TcgCard>> GetCachedCardsIfPresent(string set)
        {
            if (_cardCache.FirstOrDefault(x => x.Set == set.ToUpperInvariant()) != null)
            {
                return await Task.Run(() => _cardCache.FirstOrDefault(cardList => cardList.Set == set.ToUpperInvariant()).CardList.ToList());
            }
            else
            {
                return null;
            }
        }

        private void AddSetCardsToCache(List<TcgCard> setTcgCards)
        {
            _cardCache.Add
                (
                    new CardsCacheItem
                    {
                        Set = setTcgCards[0].Set,
                        CardList = setTcgCards,
                        TimeAdded = DateTime.Now
                    }
                );
        }
    }
}
