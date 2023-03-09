using CrudWithAspNet.Context;
using CrudWithAspNet.Interface.Repository;
using CrudWithAspNet.Model;
using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace CrudWithAspNet.Repository
{
    public class PostRepository : CommonRepository<User_Info>, IPostRepository
    {
        public PostRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
