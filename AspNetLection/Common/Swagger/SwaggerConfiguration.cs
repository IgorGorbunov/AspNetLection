using Microsoft.Extensions.DependencyInjection;

namespace AspNetLection.Common.Swagger
{
    /// <summary>
    /// Расширения для конфигурации Swagger.
    /// </summary>
    public static class SwaggerConfiguration
    {
        /// <summary>
        /// Настройка документов Swagger.
        /// </summary>
        /// <param name="services">Коллекция сервисов для DI.</param>
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerDocument(c =>
            {
                c.Title = "Dresses";
                c.DocumentName = SwaggerDocParts.Dresses;
                c.ApiGroupNames = new[] { SwaggerDocParts.Dresses };
            })
            .AddSwaggerDocument(c =>
            {
                c.Title = "Version 2";
                c.DocumentName = "v2";
                c.ApiGroupNames = new[] {"v2"};
            });
        }
    }
}
