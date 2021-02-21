using Microsoft.Extensions.Options;
using OswrenAPI.Domain.Interfaces;
using OswrenAPI.TCG.Helpers;
using OswrenAPI.TCG.Models;
using OswrenAPI.TCG.Models.MTG.Cards;
using OswrenAPI.TCG.Models.MTG.Sets;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OswrenAPI.TCG
{
    public class TcgBroker : ITcgReader
    {
        private readonly IRestClient _restClient;

        public TcgBroker(IRestClient restClient, IOptions<BrokerConfig> config)
        {
            _restClient = restClient;
            _restClient.BaseUrl = new Uri(config.Value.MagicTheGatheringAPIRoot);
        }

        public async Task<IEnumerable<Domain.Models.TcgSet>> GetSetlist()
        {
            var restRequest = new RestRequest("sets");
            
            var result = await _restClient.GetAsync<MtgSets>(restRequest).ConfigureAwait(false);

            return MtgMapper.MapSetLists(result.Sets);
        }

        public async Task<IEnumerable<Domain.Models.TcgCard>> GetMTGCardList(string set)
        {
            var cardList = new List<MtgCard>();
            var cardCount = 100;
            var page = 0;

            while (cardCount > 50)
            {
                var restRequest = new RestRequest("cards").AddParameter("set", set).AddParameter("page", ++page);
                var requestResult = await _restClient.GetAsync<MtgCards>(restRequest).ConfigureAwait(false);

                cardCount = requestResult.Cards != null ? requestResult.Cards.Count : cardCount;

                if(cardCount > 0)
                {
                    cardList.AddRange(requestResult.Cards);
                }
            }

            return MtgMapper.MapCardList(cardList);
        }
    }
}
