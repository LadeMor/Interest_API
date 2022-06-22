using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Interest_API.Models;

namespace Interest_API.Database.Interfaces
{
    public interface IUserRepository
    {
        bool UserExist(string username);
        User AddUser(User user);
        IEnumerable<User> GetAllUsers();
        IQueryable<User> GetUserById(int id);
        IQueryable<User> GetUserByUsername(string username);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}