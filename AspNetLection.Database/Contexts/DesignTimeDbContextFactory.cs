using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace AspNetLection.DAL.Contexts
{
    internal sealed class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AspNetLectionsContext>
    {
        public AspNetLectionsContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                               .SetBasePath(Directory.GetCurrentDirectory())
                               .AddJsonFile("appsettings.json", false, true)
                               .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json",
                                        true, true)
                               .AddEnvironmentVariables()
                               .Build();

            var connectionString = configuration.GetConnectionString(nameof(AspNetLectionsContext));

            var builder = new DbContextOptionsBuilder<AspNetLectionsContext>()
                   .UseNpgsql(connectionString, __options =>
                   {
                       __options.MigrationsAssembly(typeof(AspNetLectionsContext).Assembly.FullName);
                   });

            var context = new AspNetLectionsContext(builder.Options);

            return context;
        }
    }
}
