using System;

namespace Interest_API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public int Role { get; set; }
        public Int64 Rating { get; set; }
    }
}