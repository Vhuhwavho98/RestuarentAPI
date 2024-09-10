using Microsoft.Extensions.DependencyInjection;
using RestuarentAPI.Domain.IRepository;
using RestuarentAPI.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarentAPI.Infrastructure
{
    public static class InfrastructureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {

            services.AddTransient<IRestuarentRepository, RestuarentRepository>();
            return services;
        }
    }
}
