using System;
using System.Linq;
using Interest_API.Database.Dtos;
using Interest_API.Database.Interfaces;
using Interest_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Interest_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentRepository _commentRepository;

        public CommentController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<Comment> GetAllByPostId(int id)
        {
            var comments = _commentRepository.GetAllByPostId(id);
            var commentModel = comments.Select(c => new CommentDTO()
            {
                Comment_Id = c.Comment_Id,
                Post_Comment_Id = c.Post_Comment_Id,
                User_Comment_Id = c.User_Comment_Id,
                Author = c.Author,
                Text = c.Text,
                Date_Of_Comment_Creation = c.Date_Of_Comment_Creation
            });

            return Ok(commentModel);
        }

        [HttpPost]
        public IActionResult CreateComment(CommentDTO commentDto)
        {
            var comment = new Comment()
            {
                Comment_Id = commentDto.Comment_Id,
                Post_Comment_Id = commentDto.Post_Comment_Id,
                User_Comment_Id = commentDto.User_Comment_Id,
                Author = commentDto.Author,
                Text = commentDto.Text,
                Date_Of_Comment_Creation = DateTime.Now
            };
            _commentRepository.Create(comment);
            return Ok();
        }

        [HttpDelete("{id}")]
        public void DeleteComment(int id)
        {
            _commentRepository.Delete(id);
        }
    }
}