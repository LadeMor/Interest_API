using Interest_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Interest_API.Database.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Username)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(u => u.Password)
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(u => u.Email)
                .IsRequired();

            builder.Property(u => u.Description)
                .HasMaxLength(100);
            
            builder.HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

            builder.HasData(
                new User {Id = 1, 
                    Username = "LadeMor", 
                    Password = "1234", 
                    Email = "lademor@gmail.com", 
                    Description = "Web developer", 
                    RoleId = 1, 
                    Rating = 0},
                
                new User {Id = 2, 
                    Username = "Jabe", 
                    Password = "1111", 
                    Email = "jabe@gmail.com", 
                    Description = "Artist", 
                    RoleId = 2, 
                    Rating = 0},
                
                new User {Id = 3, 
                    Username = "Flomic", 
                    Password = "2222", 
                    Email = "flomy@gmail.com", 
                    Description = "Gamer", 
                    RoleId = 2, 
                    Rating = 0},
                
                new User {Id = 4, 
                    Username = "Swonsonn", 
                    Password = "3333", 
                    Email = "swon@gmail.com", 
                    Description = "C++ game developer", 
                    RoleId = 2, 
                    Rating = 0}
            );
        }
    }
}