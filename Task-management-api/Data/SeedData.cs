using Task_management_api.Models;

namespace Task_management_api.Data
{
    public static class SeedData
    {
        public static void Initialize(WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            db.Users.AddRange(
                new User { Id = 1, Username = "admin", Password = "admin", Role = UserRole.Admin },
                new User { Id = 2, Username = "user", Password = "user", Role = UserRole.User }
            );

            db.Tasks.AddRange(
                new TaskItem { Id = 1, Title = "Task 1", Description = "First task", AssignedUserId = 2 },
                new TaskItem { Id = 2, Title = "Task 2", Description = "Second task", AssignedUserId = 2 }
            );

            db.TaskComments.Add(
                new TaskComment { Id = 1, Comment = "Good work", TaskItemId = 1, UserId = 2 }
            );

            db.SaveChanges();
        }
    }
}
