using System.ComponentModel.DataAnnotations;

namespace Interest_API.Models
{
    public class Post
    {
        [Key]
        public int Post_Id { get; set; }
        public int User_Id { get; set; }
        public User User { get; set; }

        [Required]
        [StringLength(20)]
        public string Title { get; set; }
        
        [Required]
        public string Image { get; set; }
        
        [StringLength(50)]
        public string Post_Description { get; set; }
        public string Author { get; set; }
    }
}