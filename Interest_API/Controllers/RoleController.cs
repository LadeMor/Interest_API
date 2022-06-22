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
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;

        public RoleController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var roles = _roleRepository.GetAll();
            var roleModel = roles.Select(r => new RoleDTO()
            {
                Role_Id = r.Role_Id,
                Role_Name = r.Role_Name
            });

            return Ok(roleModel);
        }

        [HttpGet("{id}")]
        public ActionResult<Role> GetById(int id)
        {
            var roles = _roleRepository.GetById(id);
            var roleModel = roles.Select(r => new RoleDTO()
            {
                Role_Id = r.Role_Id,
                Role_Name = r.Role_Name
            });

            return Ok(roleModel);
        }
    }
}