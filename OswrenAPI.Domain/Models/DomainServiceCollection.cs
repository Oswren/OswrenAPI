using Microsoft.Extensions.DependencyInjection;
using OswrenAPI.Domain.Interfaces;
using OswrenAPI.Domain.Services;

namespace OswrenAPI.Domain.Models
{
    public static class DomainServiceCollection
    {
        public static void AddDomainServices(this IServiceCollection services)
        {
            services.AddTransient<IBoosterPackService, BoosterPackService>();
        }
    }
}
