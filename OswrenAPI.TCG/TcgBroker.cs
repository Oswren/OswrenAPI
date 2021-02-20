using Microsoft.Extensions.Options;
using OswrenAPI.Domain.Interfaces;
using OswrenAPI.TCG.Models;
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

        public async Task<IEnumerable<object>> GetSetlist()
        {
            var restRequest = new RestRequest("sets");
            return await _restClient.GetAsync<IEnumerable<object>>(restRequest).ConfigureAwait(false);
        }

    }
}
