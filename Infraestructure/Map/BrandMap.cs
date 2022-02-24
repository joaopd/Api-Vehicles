using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Map
{
    public class BrandMap : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                 .IsRequired(true)
                .HasColumnType("varchar(14)");

            builder.Property(x => x.Status)
                 .IsRequired(true);
        }
    }
}
