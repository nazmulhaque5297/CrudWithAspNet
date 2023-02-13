using CrudWithAspNet.Context;
using CrudWithAspNet.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudWithAspNet.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        ApplicationDbContext _dbContext;
        public PostController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public Post Add(Post post)
        {
            post.CreatedDate= DateTime.Now;
            _dbContext.Post.Add(post);
            bool isSaved = _dbContext.SaveChanges() > 0;
            return isSaved?post: null;

        }

        [HttpGet] 
        public List<Post> GelAllData()
        {
            var posts = _dbContext.Post.ToList();
            return posts;
        }
    }
}
