using Microsoft.EntityFrameworkCore;
using Task_management_api.Models;

namespace Task_management_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users => Set<User>();
        public DbSet<TaskItem> Tasks => Set<TaskItem>();
        public DbSet<TaskComment> TaskComments => Set<TaskComment>();
    }

}
