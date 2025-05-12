namespace Task_management_api.Models
{
    public class TaskComment
    {
        public int Id { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int TaskItemId { get; set; }
        public TaskItem? TaskItem { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
