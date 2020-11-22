using System.Reflection;
using AspNetLection.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetLection.DAL.Bootstrap
{
    /// <summary>
    /// Конфигурации БД.
    /// </summary>
    public static class DbConfigurations
    {
        /// <summary>
        /// Подключение DbContext.
        /// </summary>
        /// <param name="services">Коллекция сервисов.</param>
        /// <param name="configuration">Конфигурация.</param>
        public static void ConfigureDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AspNetLectionsContext>(
                options => options.UseNpgsql(
                    configuration.GetConnectionString(nameof(AspNetLectionsContext)), 
                    builder => builder.MigrationsAssembly(typeof(AspNetLectionsContext).Assembly.FullName))
            );
        }
    }
}
