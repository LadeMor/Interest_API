using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Interest_API.Models
{
    public class Role
    {
        [Key]
        public int Role_Id { get; set; }
        public string Role_Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}