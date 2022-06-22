using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Interest_API.Database.Dtos;
using Interest_API.Database.Interfaces;
using Interest_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Interest_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userRepository.GetAllUsers();
            var userModel = users.Select(u => new UserDTO()
            {
                Id = u.Id,
                Username = u.Username,
                Password = u.Password,
                Email = u.Email,
                Description = u.Description,
                RoleId = u.RoleId
            });

            return Ok(userModel);
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            var users = _userRepository.GetUserById(id);
            var userModel = users.Select(u => new UserDTO()
            {
                Id = u.Id,
                Username = u.Username,
                Password = u.Password,
                Email = u.Email,
                Description = u.Description,
                RoleId = u.RoleId
            });

            return Ok(userModel);
        }

        [HttpGet("{username}/users")]
        public ActionResult<User> GetByUsername(string username)
        {
            var users = _userRepository.GetUserByUsername(username);
            var userModel = users.Select(u => new UserDTO()
            {
                Id = u.Id,
                Username = u.Username,
                Password = u.Password,
                Email = u.Email,
                Description = u.Description,
                RoleId = u.RoleId
            });

            return Ok(userModel);
        }
        
    }
}