using TaskList.Entities;

namespace TaskList.Abstractions.Services
{
    public interface ITaskService
    {
        Task[] GetTasks();

        Task GetTask(int id);

        int CreateTask(Task task);

        void UpdateTask(Task task);

        void CompleteTask(int id);

        void DeleteTask(int id);
    }
}