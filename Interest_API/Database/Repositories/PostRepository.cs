using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interest_API.Database.Interfaces;
using Interest_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Interest_API.Database.Repositories
{
    public class PostRepository : IPostRepository
    {

        private readonly InterestContext _interestContext;

        public PostRepository(InterestContext context)
        {
            _interestContext = context;
        }
        
        public IEnumerable<Post> GetAll()
        {
            return _interestContext.Posts.ToList();
        }

        public Post GetById(int id)
        {
            return _interestContext.Posts.Find(id);
        }

        public Post GetByTitle(string title)
        {
            return _interestContext.Posts.Find(title);
        }

        public Post Create(Post post)
        {
            _interestContext.Add(post);
            _interestContext.SaveChanges();
            return post;
        }

        public void Update(Post post)
        {
            _interestContext.Update(post);
            _interestContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var postToDelete = _interestContext.Posts.Find(id);
            _interestContext.Posts.Remove(postToDelete);
            _interestContext.SaveChanges();
        }
    }
}