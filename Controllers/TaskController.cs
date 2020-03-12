using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoList.Services;
using TodoList.Models;

namespace TodoList.Controllers
{
  [Route("tasks")]
  public class TaskController : ControllerBase
  {
    private const string str = "null";
    private readonly TaskService _taskService;
    public TaskController(TaskService taskService)
    {
      this._taskService = taskService;
    }

    [HttpGet("")]
    public string GetTasks()
    {
      return str;
    }
  }
}