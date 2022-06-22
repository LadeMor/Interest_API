
using System.Collections.Generic;
using System.Linq;
using Interest_API.Database.Interfaces;
using Interest_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Interest_API.Database.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly InterestContext _interestContext;

        public UserRepository(InterestContext context)
        {
            _interestContext = context;
        }

        public bool UserExist(string username)
        {
            return _interestContext.Users.Any(u => u.Username == username);
        }

        public User AddUser(User user)
        {
            _interestContext.Add(user);
            _interestContext.SaveChanges();
            return user;
        }

        public IEnumerable<User> GetAllUsers()
        {
            var users = _interestContext.Users.Include(u => u.Role);

            return users.AsEnumerable();
        }
        
        public IQueryable<User> GetUserById(int id)
        {
            var users = _interestContext.Users.Include(u => u.Role);
            return users.Where(u => u.Id.Equals(id));
        }

        public IQueryable<User> GetUserByUsername(string username)
        {
            var users = _interestContext.Users.Include(u => u.Role);
            return users.Where(u => u.Username.Equals(username));
        }

        public void UpdateUser(User user)
        {
            _interestContext.Users.Update(user);
            _interestContext.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var userToDelete = _interestContext.Users.Find(id);
            _interestContext.Users.Remove(userToDelete);
            _interestContext.SaveChanges();
        }
    }
}