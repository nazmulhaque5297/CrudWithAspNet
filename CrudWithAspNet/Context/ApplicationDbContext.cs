using CrudWithAspNet.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudWithAspNet.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options ):base(options) { }
        public DbSet<User_Info> User_Info { get; set; }
        public DbSet<Admited_Student_Info> admited_Student_Infos { get; set; }
    }
}
