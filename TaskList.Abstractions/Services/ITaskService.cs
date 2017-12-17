using TaskList.Entities;

namespace TaskList.Abstractions.Services
{
    public interface ITaskService
    {
        Task[] GetTasks();

        Task GetTask(int id);

        int CreateTask();

        void UpdateTask(Task task);

        void CompleteTask(int id);

        void DeleteTask(int id);
    }
}