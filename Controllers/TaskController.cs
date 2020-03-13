using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoList.Services;
using TodoList.Models;

namespace TodoList.Controllers
{
  [Route("tasks")]
  [ApiController]
  public class TaskController : ControllerBase
  {
    private const string str = "null";
    private string UserId = "1";
    private readonly TaskService _taskService;
    public TaskController(TaskService taskService)
    {
      this._taskService = taskService;
    }

    [HttpGet("")]
    public List<Task> GetTasks()
    {
      return _taskService.GetTasks();
    }

    // POST api/tasks/
    [HttpPost("")]
    public Task PostTask(Task task)
    {
      task.UserId = UserId;
      return _taskService.Create(task);
    }
  }
}