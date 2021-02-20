using Microsoft.Extensions.DependencyInjection;
using OswrenAPI.Domain.Interfaces;
using RestSharp;

namespace OswrenAPI.TCG
{
    public static class TcgServiceCollection
    {
        public static void AddTcgServices(this IServiceCollection services)
        {
            services.AddTransient<IRestClient, RestClient>();
            services.AddTransient<ITcgReader, TcgBroker>();
        }
    }
}
