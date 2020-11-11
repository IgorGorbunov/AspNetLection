using AspNetLection.Services.Interfaces;
using AspNetLection.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetLection.Services.Bootstrap
{
    /// <summary>
    /// Методы засширения для конфигурации сервисов.
    /// </summary>
    public static class ServicesConfiguration
    {
        /// <summary>
        /// Конфигурация сервисов.
        /// </summary>
        /// <param name="services">Коллекция сервисов из Startup.</param>
        public static void ConfigureServices(this IServiceCollection services)
        {            
            services.AddTransient<IDressService, DressService>();
        }
    }
}
