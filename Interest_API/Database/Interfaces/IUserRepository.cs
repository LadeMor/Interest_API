using System.Collections;
using System.Collections.Generic;
using Interest_API.Models;

namespace Interest_API.Database.Interfaces
{
    public interface IUserRepository
    {
        bool UserExist(string username);
        User AddUser(User user);
        User GetUserById(int id);
        User GetUserByUsername(string username);
        IEnumerable<User> GetAllUsers();
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}