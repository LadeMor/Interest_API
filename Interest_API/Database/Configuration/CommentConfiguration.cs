using System;
using Interest_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Interest_API.Database.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Comment_Id);

            builder.Property(c => c.Text).IsRequired();
            
            builder.HasOne(p => p.Post)
                .WithMany(c => c.Comments)
                .HasForeignKey(c => c.Post_Comment_Id);

            builder.HasOne(u => u.User)
                .WithMany(c => c.Comments)
                .HasForeignKey(c => c.User_Comment_Id);

            builder.HasData(
                new Comment
                {
                    Comment_Id = 1,
                    Post_Comment_Id = 1,
                    User_Comment_Id = 5,
                    Author = "Gaib",
                    Text = "Really Cool post i really like it",
                    Date_Of_Comment_Creation = Convert.ToDateTime("06/13/2018")
                },
                new Comment
                {
                    Comment_Id = 2,
                    Post_Comment_Id = 1,
                    User_Comment_Id = 7,
                    Author = "LadeMorsdf",
                    Text = "Woowww amazing!!!!",
                    Date_Of_Comment_Creation = Convert.ToDateTime("02/23/2020")
                }, 
                new Comment
                {
                    Comment_Id = 3,
                    Post_Comment_Id = 1,
                    User_Comment_Id = 2,
                    Author = "Jabe",
                    Text = "Do you know the artist???",
                    Date_Of_Comment_Creation = Convert.ToDateTime("02/23/2020")
                });
        }
    }
}