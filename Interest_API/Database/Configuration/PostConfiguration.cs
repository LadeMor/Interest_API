using Interest_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Interest_API.Database.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p => p.Post_Id);

            builder.Property(p => p.Title)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(p => p.Image)
                .IsRequired();

            builder.Property(p => p.Post_Description)
                .HasMaxLength(50);

            builder.HasOne(p => p.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.User_Id);

            builder.HasData(
                new Post {
                    Post_Id = 1,
                    User_Id = 1,
                    Title = "Post1",
                    Image = "https://i.pinimg.com/474x/ff/13/f3/ff13f379c308e9753a6f94ea179caf47.jpg",
                    Post_Description = "First post in my app",
                    Author = "LadeMor" 
                },
                
                new Post {
                    Post_Id = 2,
                    User_Id = 1,
                    Title = "Cool car",
                    Image = "https://i.pinimg.com/474x/3b/ff/38/3bff3800984503efe1edaeb596755b22.jpg",
                    Post_Description = "Really cool car",
                    Author = "LadeMor"
                },
                new Post {
                    Post_Id = 3,
                    User_Id = 1,
                    Title = "Cool anime",
                    Image = "https://i.pinimg.com/474x/ee/cc/60/eecc60d000dbe7c6d5bf91ec9e46ed45.jpg",
                    Post_Description = "Really cool anime",
                    Author = "LadeMor"
                },
                new Post {
                    Post_Id = 4,
                    User_Id = 1,
                    Title = "Cool car",
                    Image = "https://i.pinimg.com/474x/3b/ff/38/3bff3800984503efe1edaeb596755b22.jpg",
                    Post_Description = "Really cool car",
                    Author = "LadeMor"
                });
        }
    }
}