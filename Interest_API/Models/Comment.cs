using System;
using System.ComponentModel.DataAnnotations;

namespace Interest_API.Models
{
    public class Comment
    {
        [Key]
        public int Comment_Id { get; set; }
        public int Post_Comment_Id { get; set; }
        public int User_Comment_Id { get; set; }
        public Post Post { get; set; }
        public User User { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public DateTime Date_Of_Comment_Creation { get; set; }
    }
}