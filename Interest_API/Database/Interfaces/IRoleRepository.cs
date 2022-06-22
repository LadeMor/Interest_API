using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Interest_API.Models;

namespace Interest_API.Database.Interfaces
{
    public interface IRoleRepository
    {
        IEnumerable<Role> GetAll();
        IQueryable<Role> GetById(int id);
    }
}