using System.Collections;
using System.Collections.Generic;

namespace Interest_API.Models
{
    public class Role
    {
        public int Role_Id { get; set; }
        public string Role_Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}