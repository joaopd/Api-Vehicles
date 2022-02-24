using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Map
{
    public class VehicleMap : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.YearOfManufacture)
                 .IsRequired(true)
                .HasColumnType("varchar(4)");

            builder.Property(x => x.YearModel)
                 .IsRequired(true)
                .HasColumnType("varchar(4)");

            builder.Property(x => x.Status)
                 .IsRequired(true);

            builder.Property(x => x.Renavan)
                 .IsRequired(true)
                .HasColumnType("varchar(11)");

            builder.Property(x => x.Model)
                 .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.Property(x => x.Mileage)
                 .IsRequired(true)
                .HasColumnType("varchar(7)");

            builder.Property(x => x.Value)
                 .IsRequired(true)
                .HasColumnType("decimal(5,2)");
        }
    }
}
