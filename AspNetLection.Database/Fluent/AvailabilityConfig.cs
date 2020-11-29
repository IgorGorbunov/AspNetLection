using AspNetLection.DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetLection.DAL.Fluent
{
    /// <summary>
    /// Конфигурация миграций для <see cref="Availability"/>.
    /// </summary>
    public class AvailabilityConfig : IEntityTypeConfiguration<Availability>
    {
        /// <summary>
        /// Конфигурирование сущности <see cref="Availability"/>.
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Availability> builder)
        {
            builder.BaseEntityWithLinksConfig<Availability, Dress, Shop>(
                e => e.Availabilities);

            builder.Property(x => x.Count)
                .IsRequired();

            builder.ToTable("Availabilities");
        }
    }
}
