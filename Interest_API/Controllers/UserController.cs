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

        [HttpGet("{username}/exist")]
        public bool UserExistByUsername(string username)
        {
            return _userRepository.UserExistByUsername(username);
        }

        [HttpGet("{email}/user")]
        public bool UserExistByEmail(string email)
        {
            return _userRepository.UserExistByEmail(email);
        }

        [HttpGet("{password}/{email}")]
        public bool UserValidateEmail(string password, string email)
        {
            return _userRepository.UserEmailValidate(password, email);
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
        
        [HttpGet("{email}/userbyemail")]
        public ActionResult<User> GetByEmail(string email)
        {
            var users = _userRepository.GetUserByEmail(email);
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

        [HttpPost]
        public IActionResult AddUser(UserDTO userDto)
        {
            var user = new User()
            {
                Username = userDto.Username,
                Password = userDto.Password,
                Email = userDto.Email,
                Description = userDto.Description,
                RoleId = 2
            };
            _userRepository.AddUser(user);
            return Ok();
        }
        
    }
}