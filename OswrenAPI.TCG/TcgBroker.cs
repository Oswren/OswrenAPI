using OswrenAPI.Domain.Interfaces;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OswrenAPI.TCG
{
    public class TcgBroker : ITcgReader
    {
        private IRestClient _restClient;

        public TcgBroker(IRestClient restClient)
        {
            _restClient = restClient;
        }

        public async Task<IEnumerable<object>> GetSetlist()
        {
            var restRequest = new RestRequest("");
            return await _restClient.GetAsync<IEnumerable<object>>(restRequest);
        }

    }
}
