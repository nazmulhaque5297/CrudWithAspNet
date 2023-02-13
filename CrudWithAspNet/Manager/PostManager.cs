using CrudWithAspNet.Context;
using CrudWithAspNet.Interface.Manager;
using CrudWithAspNet.Interface.Repository;
using CrudWithAspNet.Model;
using CrudWithAspNet.Repository;
using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;

namespace CrudWithAspNet.Manager
{
    public class PostManager : CommonManager<Post>, IPostManager
    {
        public PostManager(ApplicationDbContext _dbContext) : base(new PostRepository(_dbContext))
        {
        }
    }
}
