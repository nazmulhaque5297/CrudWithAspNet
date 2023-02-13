using CrudWithAspNet.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudWithAspNet.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options ):base(options) { }
        public DbSet<Post> Post { get; set; }
    }
}
