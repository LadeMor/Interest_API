using System.Collections.Generic;
using Interest_API.Models;

namespace Interest_API.Database.Dtos
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public int RoleId { get; set; }
    }
}