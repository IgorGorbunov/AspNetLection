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
    /// ������������ ����������.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// �������������� ����� ��������� ������ <see cref="Startup"/>.
        /// </summary>
        /// <param name="configuration">������������.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// ������������.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// M���� ���������� ��� ������ ����������. ������������ ��� ����������� �������� � IoC ����������.
        /// </summary>
        /// <param name="services">��������� ��������.</param>
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
        /// M���� ���������� ��� ������ ����������. ������������ ��� ������������ ��������� ��� ��������� HTTP �������.
        /// </summary>
        /// <param name="app">�������� ������������ ����������.</param>
        /// <param name="env">���������� �� ���������, � ������� �������� ����������.</param>
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
