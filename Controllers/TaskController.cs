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

    [HttpPost("")]
    public Task CreateTask(Task task)
    {
      return _taskService.Create(task);
    }

    [HttpGet("")]
    public List<Task> GetTasks()
    {
      return _taskService.Get();
    }

    [HttpDelete("")]
    public void DeleteTasks()
    {
      _taskService.DeleteAll();
    }

    [HttpGet("{id}")]
    public List<Task> GetTaskById(int id)
    {
      // try
      // {
      return _taskService.GetById(id);
      // }
      // catch (ExceptionGetById m)
      // {
      // return NotFound();
      // }
    }
  }
}