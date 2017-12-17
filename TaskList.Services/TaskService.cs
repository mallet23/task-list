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
        private IRepository Repository { get; }

        public TaskService(IRepository repository)
        {
            Repository = repository;
        }

        void ITaskService.CompleteTask(int id)
        {
            using (var context = Repository.CreateContext())
            {
                var task = context.Set<DbTask>().FirstOrDefault(p => p.Id == id);

                if (task == null)
                {
                    throw new ArgumentException(nameof(id));
                }

                task.IsCompleted = true;

                context.SaveChanges();
            }
        }

        public void DeleteTask(int id)
        {
            using (var context = Repository.CreateContext())
            {
                var task = context.Set<DbTask>().FirstOrDefault(p => p.Id == id);

                if (task == null)
                {
                    return;
                }

                context.Set<DbTask>().Remove(task);

                context.SaveChanges();
            }
        }

        public int CreateTask(Task task)
        {
            using (var context = Repository.CreateContext())
            {
                var newTask = context.Set<DbTask>()
                    .Add(new DbTask
                    {
                        Description = task.Description,
                        Name = task.Name,
                        Priority = task.Priority,
                        TimeToComplete = task.TimeToComplete,
                        IsCompleted = false
                    });

                context.SaveChanges();

                return newTask.Id;
            }
        }

        public Task GetTask(int id)
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

        public Task[] GetTasks()
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
                    }).ToArray();
            }
        }

        public void UpdateTask(Task task)
        {
            using (var context = Repository.CreateContext())
            {
                var dbTask = context.Set<DbTask>().FirstOrDefault(p => p.Id == task.Id);

                if (dbTask == null)
                {
                    throw new ArgumentException(nameof(task.Id));
                }

                if (dbTask.IsCompleted)
                {
                    throw new Exception("You cannot change completed task!");
                }

                dbTask.Description = task.Description;
                dbTask.Name = task.Name;
                dbTask.Priority = dbTask.Priority;
                dbTask.TimeToComplete = dbTask.TimeToComplete;

                context.SaveChanges();
            }
        }
    }
}