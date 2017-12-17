using System.Linq;
using TaskList.Abstractions.Services;
using TaskList.Entities;

namespace TaskList.Services
{
    public class TaskService : ITaskService
    {
        private readonly Task[] _tasksModel =
        {
            new Task
            {
                Id = 1,
                Name = "Name 1",
                Description = "Description 1",
                Priority = "Priority 1",
                TimeToComplete = "TimeToComplete 1",
                IsCompleted = true,
            },
            new Task
            {
                Id = 2,
                Name = "Name 2",
                Description = "Description 2",
                Priority = "Priority 2",
                TimeToComplete = "TimeToComplete 2",
                IsCompleted = true,
            },
            new Task
            {
                Id = 3,
                Name = "Name 3",
                Description = "Description 3",
                Priority = "Priority 3",
                TimeToComplete = "TimeToComplete 3",
                IsCompleted = true,
            },
        };

        void ITaskService.CompleteTask(int id)
        {
            throw new System.NotImplementedException();
        }

        int ITaskService.CreateTask()
        {
            throw new System.NotImplementedException();
        }

        Task ITaskService.GetTask(int id)
        {
            return _tasksModel.FirstOrDefault(p => p.Id == id);
        }

        Task[] ITaskService.GetTasks()
        {
            return _tasksModel;
        }

        void ITaskService.UpdateTask(Task task)
        {
            throw new System.NotImplementedException();
        }
    }
}