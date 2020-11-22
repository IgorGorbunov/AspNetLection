using System.Reflection;
using AspNetLection.Common.Swagger;
using AspNetLection.Services.Bootstrap;
using AspNetLection.Services.Services;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AspNetLection.DAL.Bootstrap;
using AspNetLections.Repositories.Bootstrap;

namespace AspNetLection
{
    /// <summary>
    /// Конфигурация приложения.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Startup"/>.
        /// </summary>
        /// <param name="configuration">Конфигурация.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Конфигурация.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Mетод вызывается для средой исполнения. Используется для регистрации сервисов в IoC контейнере.
        /// </summary>
        /// <param name="services">Коллекция сервисов.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureDb(Configuration);
            services.ConfigureRepositories();
            services.AddControllers();
            services.ConfigureServices();
            services.AddAutoMapper(typeof(DressService).GetTypeInfo().Assembly);
            services.ConfigureSwagger();
        }

        /// <summary>
        /// Mетод вызывается для средой исполнения. Используется для конфигурации окружения для обработки HTTP запроса.
        /// </summary>
        /// <param name="app">Средство конфигурации приложения.</param>
        /// <param name="env">Информация об окружении, в котором работает приложение.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseCors();
            app.UseOpenApi();
            app.UseSwaggerUi3();
        }
    }
}
