using System;
using System.Linq;
using TaskList.Abstractions.Repositories;
using TaskList.Abstractions.Services;
using TaskList.DbEntities;
using TaskList.Entities;

namespace TaskList.Services
{
    public class TaskService : ITaskService
    {
        private IRepository Repository { get; set; }

        public TaskService(IRepository repository)
        {
            Repository = repository;
        }

        void ITaskService.CompleteTask(int id)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteTask(int id)
        {
            throw new System.NotImplementedException();
        }

        int ITaskService.CreateTask()
        {
            throw new System.NotImplementedException();
        }

        Task ITaskService.GetTask(int id)
        {
            using (var context = Repository.CreateContext())
            {
                var dbTasks = context.Set<DbTask>().FirstOrDefault(p => p.Id == id);

                if (dbTasks == null)
                {
                    throw new ArgumentException(nameof(id));
                }

                return new Task
                    {
                        Id = dbTasks.Id,
                        Description = dbTasks.Description,
                        IsCompleted = dbTasks.IsCompleted,
                        Name = dbTasks.Name,
                        Priority = dbTasks.Priority,
                        TimeToComplete = dbTasks.TimeToComplete,
                    };
            }
        }

        Task[] ITaskService.GetTasks()
        {
            using (var context = Repository.CreateContext())
            {
                var dbTasks = context.Set<DbTask>().ToList();

                return dbTasks.ConvertAll(x => new Task
                    {
                        Id = x.Id,
                        Description = x.Description,
                        IsCompleted = x.IsCompleted,
                        Name = x.Name,
                        Priority = x.Priority,
                        TimeToComplete = x.TimeToComplete,
                    })
                    .ToArray();
            }
        }

        void ITaskService.UpdateTask(Task task)
        {
            throw new System.NotImplementedException();
        }
    }
}