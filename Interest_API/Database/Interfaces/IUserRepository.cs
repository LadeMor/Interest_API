using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Interest_API.Models;

namespace Interest_API.Database.Interfaces
{
    public interface IUserRepository
    {
        bool UserExistByUsername(string username);
        bool UserExistByEmail(string username);
        bool UserEmailValidate(string email, string password);
        User AddUser(User user);
        IEnumerable<User> GetAllUsers();
        IQueryable<User> GetUserById(int id);
        IQueryable<User> GetUserByUsername(string username);
        IQueryable<User> GetUserByEmail(string email);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}