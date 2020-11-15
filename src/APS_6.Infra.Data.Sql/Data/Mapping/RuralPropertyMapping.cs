using APS_6.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APS_6.Infra.Data.Sql.Data.Mapping
{
    public class RuralPropertyMapping : IEntityTypeConfiguration<RuralProperty>
    {
        public void Configure(EntityTypeBuilder<RuralProperty> builder)
        {
            builder.ToTable("RuralProperty");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar(50)");

            builder.Property(t => t.Street)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar(50)");

            builder.Property(t => t.BuildingNumber)
                .IsRequired();

            builder.Property(t => t.District)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar(50)");

            builder.Property(t => t.PostalCode)
                .IsRequired()
                .HasMaxLength(9)
                .HasColumnType("varchar(9)");

            builder.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnType("varchar(30)");

            builder.Property(t => t.State)
                .IsRequired()
                .HasMaxLength(2)
                .HasColumnType("varchar(2)");
        }
    }
}
