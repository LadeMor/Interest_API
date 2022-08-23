namespace Interest_API.Database.Dtos
{
    public class PostDTO
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Post_Description { get; set; }
        public string Author { get; set; }
    }
}