namespace TaskManager.Api.Models

{
    public enum TaskState { ToDo = 0, InProgress = 1, Done = 2 }
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } =  string.Empty;
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public TaskState State { get; set; } = TaskState.ToDo;
        public int? Priority { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
