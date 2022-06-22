using System.Collections.Generic;
using System.Linq;
using Interest_API.Database.Interfaces;
using Interest_API.Models;
using Microsoft.EntityFrameworkCore;

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
            var roles = _interestContext.Roles
                .Include(r => r.Users);
            
            return roles.AsEnumerable();
        }

        public IQueryable<Role> GetById(int id)
        {
            var roles = _interestContext.Roles
                .Include(r => r.Users);

            return roles.Where(r => r.Role_Id.Equals(id));
        }
    }
}