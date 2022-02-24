using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Map
{
    public class OwnerMap : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Document)
                 .IsRequired(true)
                .HasColumnType("varchar(14)");

            builder.HasIndex(x => x.Document)
                .IsUnique();

            builder.Property(x => x.Email)
                 .IsRequired(true)
                .HasColumnType("varchar(50)");

            builder.HasIndex(x => x.Email)
                .IsUnique();

            builder.Property(x => x.Name)
                 .IsRequired(true)
                .HasColumnType("varchar(250)");

            builder.Property(x => x.Status)
                 .IsRequired(true);

            builder.OwnsOne(x => x.Address)
                 .Property(p => p.Street)
                 .IsRequired(true)
                 .HasColumnType("varchar(250)");

            builder.OwnsOne(x => x.Address)
                 .Property(p => p.Cep)
                 .IsRequired(true)
                 .HasColumnType("varchar(8)");

            builder.OwnsOne(x => x.Address)
                 .Property(p => p.Street)
                 .IsRequired(true)
                 .HasColumnType("varchar(250)");

            builder.OwnsOne(x => x.Address)
                 .Property(p => p.Neighborhood)
                 .IsRequired(true)
                 .HasColumnType("varchar(250)");

            builder.OwnsOne(x => x.Address)
                 .Property(p => p.State)
                 .IsRequired(true)
                 .HasColumnType("varchar(2)");

        }
    }
}
