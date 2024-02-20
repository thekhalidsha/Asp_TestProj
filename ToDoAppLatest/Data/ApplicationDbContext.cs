using Microsoft.EntityFrameworkCore;
using ToDoAppLatest.Models;

namespace ToDoAppLatest.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options ):base (options) 
        {
        }
        public DbSet<ToDoType> ToDoType { get; set; }
        public DbSet<ToDo> ToDo { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
    }
}
