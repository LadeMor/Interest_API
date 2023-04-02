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
            var posts = _interestContext.Posts.Include(p => p.User);
            
            return posts.AsEnumerable();
        }

        public Post GetById(int id)
        {
            var post = _interestContext.Posts
                .Include(p => p.User)
                .SingleOrDefault(p => p.Post_Id == id);

            return post;
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