using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Interest_API.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Username { get; set; }
        
        [Required]
        [StringLength(80, MinimumLength = 8)]
        public string Password { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        
        [StringLength(100)]
        public string Description { get; set; }
        public int RoleId { get; set; }
        public Role Role;
        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public string Profile_Photo { get; set; }
    }
}