using CrudWithAspNet.Context;
using CrudWithAspNet.Interface.Repository;
using CrudWithAspNet.Model;
using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace CrudWithAspNet.Repository
{
    public class PostRepository : CommonRepository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
