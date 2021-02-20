using Microsoft.Extensions.DependencyInjection;
using OswrenAPI.Domain.Interfaces;
using OswrenAPI.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
