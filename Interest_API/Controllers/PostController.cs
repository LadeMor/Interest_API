using System;
using System.Collections;
using System.Linq;
using Interest_API.Database;
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
            var post = _postRepository.GetById(id);
            var postModel = new Post()
            {
                Post_Id = post.Post_Id,
                User_Id = post.User_Id,
                Title = post.Title,
                Image = post.Image,
                Post_Description = post.Post_Description,
                Author = post.User.Username,
                Date_Of_Creation = post.Date_Of_Creation
            };

            return Ok(postModel);
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

        [HttpPut("{id}")]
        public IActionResult UpdatePost(int id, [FromBody] PostDTO postDto)
        {
            if (postDto == null)
            {
                return BadRequest();
            }

            var existingPost = _postRepository.GetById(id);
            if (existingPost == null)
            {
                return NotFound();
            }

            existingPost.User_Id = postDto.User_Id;
            existingPost.Title = postDto.Title;
            existingPost.Image = postDto.Image;
            existingPost.Post_Description = postDto.Post_Description;
            existingPost.Author = postDto.Author;
            existingPost.Date_Of_Creation = postDto.Date_Of_Creation;

            _postRepository.Update(existingPost);

            return Ok();
        }

        [HttpDelete("{id}")]
        public void DeletePost(int id)
        {
            _postRepository.Delete(id);
        }
    }
}