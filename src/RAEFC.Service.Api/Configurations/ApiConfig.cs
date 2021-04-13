using Microsoft.Extensions.DependencyInjection;
using System;

namespace RAEFC.Service.Api.Configurations
{
    public static class ApiConfig
    {
        public static void AddApiConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddControllers();
        }
    }
}