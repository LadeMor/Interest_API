using System.Collections.Generic;
using System.Linq;
using Interest_API.Database.Interfaces;
using Interest_API.Models;

namespace Interest_API.Database.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly InterestContext _interestContext;

        public RoleRepository(InterestContext context)
        {
            _interestContext = context;
        }
        
        public IEnumerable<Role> GetAll()
        {
            return _interestContext.Roles.ToList();
        }

        public Role GetById(int id)
        {
            return _interestContext.Roles.Find(id);
        }
    }
}