using AspNetLection.DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetLection.DAL.Fluent
{
    public class AvailabilityConfig : IEntityTypeConfiguration<Availability>
    {
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
