using Interest_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Interest_API.Database.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.Role_Id);

            builder.Property(r => r.Role_Name)
                .HasMaxLength(20)
                .IsRequired();

            builder.HasIndex(r => r.Role_Name)
                .IsUnique();

            builder.HasData(
                new Role {Role_Id = 1, Role_Name = "administrator"},
                new Role {Role_Id = 2, Role_Name = "user"}
            );
        }
    }
}