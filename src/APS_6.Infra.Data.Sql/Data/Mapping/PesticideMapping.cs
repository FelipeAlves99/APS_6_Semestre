using APS_6.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APS_6.Infra.Data.Sql.Data.Mapping
{
    public class PesticideMapping : IEntityTypeConfiguration<Pesticide>
    {
        public void Configure(EntityTypeBuilder<Pesticide> builder)
        {
            builder.ToTable("Pesticide");

            builder.HasKey(p => p.Id).HasName("Id");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Legal)
                .IsRequired();

            builder.Property(p => p.ToxicLevel)
                .IsRequired();
        }
    }
}
