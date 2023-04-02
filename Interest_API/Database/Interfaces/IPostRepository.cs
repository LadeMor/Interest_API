using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interest_API.Models;

namespace Interest_API.Database.Interfaces
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetAll();
        Post GetById(int id);
        Post Create(Post post);
        void Update(Post post);
        void Delete(int id);
    }
}