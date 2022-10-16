using System;
using System.Collections;
using System.Linq;
using Interest_API.Database.Dtos;
using Interest_API.Database.Interfaces;
using Interest_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Interest_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;

        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            var posts = _postRepository.GetAll();
            var postsModel = posts.Select(p => new PostDTO()
            {
                Id = p.Post_Id,
                User_Id = p.User_Id,
                Title = p.Title,
                Image = p.Image,
                Post_Description = p.Post_Description,
                Author = p.User.Username,
                Date_Of_Creation = p.Date_Of_Creation
            });

            return Ok(postsModel);
        }

        [HttpGet("{id}")]
        public ActionResult<Post> GetPostId(int id)
        {
            var posts = _postRepository.GetById(id);
            var postsModel = posts.Select(p => new PostDTO()
            {
                Id = p.Post_Id,
                User_Id = p.User_Id,
                Title = p.Title,
                Image = p.Image,
                Post_Description = p.Post_Description,
                Author = p.User.Username,
                Date_Of_Creation = p.Date_Of_Creation
            });

            return Ok(postsModel);
        }

        [HttpPost]
        public IActionResult CreatePost(PostDTO postDto)
        {
            var post = new Post()
            {
                User_Id = postDto.User_Id,
                Post_Id = postDto.Id,
                Title = postDto.Title,
                Image = postDto.Image,
                Post_Description = postDto.Post_Description,
                Author = postDto.Author,
                Date_Of_Creation = DateTime.Now
            };

            _postRepository.Create(post);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdatePost(PostDTO postDto)
        {
            var post = new Post()
            {
                User_Id = postDto.User_Id,
                Post_Id = postDto.Id,
                Title = postDto.Title,
                Image = postDto.Image,
                Post_Description = postDto.Post_Description,
                Author = postDto.Author,
                Date_Of_Creation = postDto.Date_Of_Creation
            };
            _postRepository.Update(post);
            return Ok();
        }

        [HttpDelete("{id}")]
        public void DeletePost(int id)
        {
            _postRepository.Delete(id);
        }
    }
}