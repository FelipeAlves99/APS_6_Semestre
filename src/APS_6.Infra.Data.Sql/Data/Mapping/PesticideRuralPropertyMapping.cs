using APS_6.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APS_6.Infra.Data.Sql.Data.Mapping
{
    public class PesticideRuralPropertyMapping : IEntityTypeConfiguration<PesticideRuralProperty>
    {
        public void Configure(EntityTypeBuilder<PesticideRuralProperty> builder)
        {
            builder.HasKey(pr => new { pr.PesticideId, pr.RuralPropertyId });

            builder.HasOne(pr => pr.Pesticide)
                .WithMany(p => p.PesticideRuralProperties)
                .HasForeignKey(pr => pr.PesticideId);

            builder.HasOne(pr => pr.RuralProperty)
                .WithMany(r => r.PesticideRuralProperties)
                .HasForeignKey(pr => pr.RuralPropertyId);
        }
    }
}
