using System;

namespace Interest_API.Database.Dtos
{
    public class CommentDTO
    {
        public int Comment_Id { get; set; }
        public int Post_Comment_Id { get; set; }
        public int User_Comment_Id { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public DateTime Date_Of_Comment_Creation { get; set; }
    }
}