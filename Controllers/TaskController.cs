using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoList.Services;
using TodoList.Models;
using System.Linq;

namespace TodoList.Controllers
{
  [Route("tasks")]
  [ApiController]
  public class TaskController : ControllerBase
  {
    private readonly TaskService _taskService;
    public TaskController(TaskService taskService)
    {
      this._taskService = taskService;
    }

    [HttpGet("")]
    public List<Task> GetTasks()
    {
      return _taskService.Get();
    }

    [HttpPost("")]
    public Task CreateTask(Task task)
    {
      return _taskService.Create(task);
    }

    [HttpDelete("")]
    public void DeleteTasks()
    {
      _taskService.DeleteAll();
    }
  }
}