using TaskManager.Api.Models;

namespace TaskManager.Api.Data;

public static class Seed
{
    public static async Task ApplyAsync(AppDbContext db)
    {
        if (!db.Tasks.Any())
        {
            db.Tasks.AddRange(
                new TaskItem { Title = "Развернуть API", Priority = 2 },
                new TaskItem { Title = "Сделать фронт", State = TaskState.InProgress },
                new TaskItem { Title = "Написать README", State = TaskState.ToDo, DueDate = DateTime.UtcNow.AddDays(2) }
            );
            await db.SaveChangesAsync();
        }
    }
}