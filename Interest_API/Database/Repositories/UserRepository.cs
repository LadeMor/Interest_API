
using System.Collections.Generic;
using System.Linq;
using Interest_API.Database.Interfaces;
using Interest_API.Models;

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

        public User GetUserById(int id)
        {
            return _interestContext.Users.Find(id);
        }

        public User GetUserByUsername(string username)
        {
            return _interestContext.Users.Find(username);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _interestContext.Users.ToList();
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