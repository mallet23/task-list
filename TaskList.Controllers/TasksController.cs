using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using TaskList.Abstractions.Services;
using TaskList.Entities;
using TaskList.ViewModels;

namespace TaskList.Controllers
{
    public class TasksController : BaseApiController
    {
        private ITaskService TaskService { get; }

        public TasksController(ITaskService taskService)
        {
            TaskService = taskService;
        }

        [HttpGet]
        public IEnumerable<TaskModel> GetTasks()
        {
            return TaskService.GetTasks().Select(x=> new TaskModel
            {
                Id = x.Id,
                Description = x.Description,
                IsCompleted = x.IsCompleted,
                Name = x.Name,
                Priority = x.Priority,
                TimeToComplete = x.TimeToComplete,
            });
        }

        [HttpGet]
        [ResponseType(typeof(TaskModel))]
        public IHttpActionResult GetTask(int id)
        {
            var task = TaskService.GetTask(id);
            if (task == null)
            {
                return NotFound();
            }

            var taskModel = new TaskModel
            {
                Id = task.Id,
                Description = task.Description,
                IsCompleted = task.IsCompleted,
                Name = task.Name,
                Priority = task.Priority,
                TimeToComplete = task.TimeToComplete,
            };

            return Ok(taskModel);
        }

        [HttpPost]
        [ResponseType(typeof(TaskModel))]
        public IHttpActionResult Create([FromBody] TaskModel task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            task.Id = TaskService.CreateTask(new Task
            {
                Description = task.Description,
                Name = task.Name,
                Priority = task.Priority,
                TimeToComplete = task.TimeToComplete,
            });

            return Ok(task);
        }

        [HttpPut]
        [ResponseType(typeof(void))]
        public IHttpActionResult CompleteTask(int id)
        {
            TaskService.CompleteTask(id);

            return Ok();
        }
    }
}