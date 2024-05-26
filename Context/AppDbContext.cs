using Microsoft.EntityFrameworkCore;
using ToDoItemApi.Models;

namespace ToDoItemApi.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<ToDoItem> ToDoItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ToDoItem_User> ToDoItem_Users { get; set; }
    }
}
