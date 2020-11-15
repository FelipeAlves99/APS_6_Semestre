using APS_6.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APS_6.Infra.Data.Sql.Data.Mapping
{
    public class TicketMapping : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Ticket")
                .HasOne(t => t.RuralProperty)
                .WithMany(rp => rp.Tickets)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Value)
                .IsRequired()
                .HasColumnType("money");

            builder.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(1024)
                .HasColumnType("varchar(1024)");
        }
    }
}
