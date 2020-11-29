using AspNetLection.DAL.Domain;
using AspNetLection.DAL.Fluent;
using Microsoft.EntityFrameworkCore;

namespace AspNetLection.DAL.Contexts
{
    /// <summary>
    /// Контекст для работы с данными БД "Магазины одежды".
    /// </summary>
    public class AspNetLectionsContext : DbContext
    {
        /// <summary>
        /// Магазины.
        /// </summary>
        public DbSet<Shop> Shops { get; set; }

        /// <summary>
        /// Поставщики.
        /// </summary>
        public DbSet<Provider> Providers { get; set; }

        /// <summary>
        /// Одежда.
        /// </summary>
        public DbSet<Dress> Dresses { get; set; }

        /// <summary>
        /// Наличие в магазинах.
        /// </summary>
        public DbSet<Availability> Availabilities { get; set; }

        /// <summary>
        /// Инициализирует экземпляр <see cref="AspNetLectionsContext"/>.
        /// </summary>
        /// <param name="options">Опции для конфигурации контекста.</param>
        public AspNetLectionsContext(DbContextOptions options) : base(options) 
        {
        }

        /// <summary>
        /// Правила создания сущностей.
        /// </summary>
        /// <param name="builder">Билдер моделей.</param>
        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.ApplyConfiguration(new AvailabilityConfig());
        }
    }
}
