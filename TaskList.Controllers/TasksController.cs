using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TaskList.Abstractions;
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

        private readonly TaskModel[] _tasksModel =
        {
            new TaskModel
            {
                Id = 1,
                Name = "Name 1",
                Description = "Description 1",
                Priority = "Priority 1",
                TimeToComplete = "TimeToComplete 1",
                IsCompleted = true,
            },
            new TaskModel
            {
                Id = 2,
                Name = "Name 2",
                Description = "Description 2",
                Priority = "Priority 2",
                TimeToComplete = "TimeToComplete 2",
                IsCompleted = true,
            },
            new TaskModel
            {
                Id = 3,
                Name = "Name 3",
                Description = "Description 3",
                Priority = "Priority 3",
                TimeToComplete = "TimeToComplete 3",
                IsCompleted = true,
            },
        };

        [HttpGet]
        public IEnumerable<TaskModel> GetTasks()
        {
            return _tasksModel;
        }

        [HttpGet]
        public IHttpActionResult GetTask(int id)
        {
            var task = _tasksModel.FirstOrDefault(p => p.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }
    }
}