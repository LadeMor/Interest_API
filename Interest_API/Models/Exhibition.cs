using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Interest_API.Models
{
    public class Exhibition
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int User_Id { get; set; }
        public User User { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [StringLength(100)]
        public string Exhibition_Description { get; set; }
        [Required]
        public string Author { get; set; }
        public DateTime Date_Of_Starting { get; set; }
        public DateTime Date_Of_Ending { get; set; }
        public ICollection<Post> Posts { get; set; }

    }
}