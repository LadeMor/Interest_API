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
        }
    }
}