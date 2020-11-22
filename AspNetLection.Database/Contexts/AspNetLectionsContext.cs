using AspNetLection.DAL.Domain;
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
        public AspNetLectionsContext(DbContextOptions options) : base(options) 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
