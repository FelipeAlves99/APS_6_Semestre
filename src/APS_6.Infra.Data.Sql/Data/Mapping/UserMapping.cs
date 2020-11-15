using APS_6.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APS_6.Infra.Data.Sql.Data.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnType("varchar(15)");

            builder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnType("varchar(30)");

            builder.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnType("varchar(15)");

            builder.Property(t => t.Permission)
                .IsRequired();
        }
    }
}
