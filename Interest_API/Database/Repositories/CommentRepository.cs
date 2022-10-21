using System.Linq;
using Interest_API.Database.Interfaces;
using Interest_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Interest_API.Database.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly InterestContext _interestContext;

        public CommentRepository(InterestContext context)
        {
            _interestContext = context;
        }
        
        public IQueryable<Comment> GetAllByPostId(int id)
        {
            var comments = _interestContext.Comments.Include(c => c.Post);

            return comments.Where(c => c.Post_Comment_Id.Equals(id));
        }

        public Comment Create(Comment comment)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Comment comment)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}