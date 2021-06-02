using Microsoft.Extensions.DependencyInjection;
using RAEFC.Domain.Core.Data;
using RAEFC.Domain.Interafaces.Repository;
using RAEFC.Infrastructure.Repository.Repository;
using RAEFC.Infrastructure.Repository.UoW;
using System;

namespace RAEFC.Service.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}