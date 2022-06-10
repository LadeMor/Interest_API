using System;
using System.ComponentModel.DataAnnotations;

namespace Interest_API.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Username { get; set; }
        
        [Required]
        [StringLength(80)]
        public string Password { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        
        [StringLength(100)]
        public string Description { get; set; }
        public int Role { get; set; }
        public Int64 Rating { get; set; }
    }
}