using System.Collections;
using System.Collections.Generic;
using Interest_API.Models;

namespace Interest_API.Database.Interfaces
{
    public interface IRoleRepository
    {
        IEnumerable<Role> GetAll();
        Role GetById(int id);
    }
}