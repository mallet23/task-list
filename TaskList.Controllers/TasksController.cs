using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TaskList.Abstractions.Services;
using TaskList.ViewModels;

namespace TaskList.Controllers
{
    public class TasksController : ApiController
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public IEnumerable<TaskModel> GetTasks()
        {
            return _taskService.GetTasks().Select(x=> new TaskModel
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
        public IHttpActionResult GetTask(int id)
        {
            var task = _taskService.GetTask(id);
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
    }
}