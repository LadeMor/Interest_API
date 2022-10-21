using System.Collections.Generic;
using System.Linq;
using Interest_API.Models;

namespace Interest_API.Database.Interfaces
{
    public interface ICommentRepository
    {
        IQueryable<Comment> GetAllByPostId(int id);
        Comment Create(Comment comment);
        void Update(Comment comment);
        void Delete(int id);
    }
}