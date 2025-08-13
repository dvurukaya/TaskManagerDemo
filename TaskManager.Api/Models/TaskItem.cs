namespace TaskManager.Api.Models

{
    public enum TaskStatus { ToDo = 0, InProgress = 1, Done = 2 }
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public TaskStatus Status { get; set; } = TaskStatus.ToDo;
        public int? Priority { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
