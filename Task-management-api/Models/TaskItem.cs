namespace Task_management_api.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int AssignedUserId { get; set; }
        public User? AssignedUser { get; set; }
    }
}
