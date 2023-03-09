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
        public User_Info Add(User_Info post)
        {
            post.CreatedDate= DateTime.Now;
            _dbContext.User_Info.Add(post);
            bool isSaved = _dbContext.SaveChanges() > 0;
            return isSaved?post: null;

        }

        [HttpGet] 
        public List<User_Info> GelAllData()
        {
            var posts = _dbContext.User_Info.ToList();
            return posts;
        }
    }
}
