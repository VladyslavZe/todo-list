using Microsoft.AspNetCore.Mvc;
using TodoList.Services;

namespace TodoList.Controllers
{
  [Route("tasks")]
  public class TaskController : ControllerBase
  {
    private readonly TaskService _taskService;
    public TaskController(TaskService taskService)
    {
      this._taskService = taskService;
    }

    [HttpGet("")]
    public string[] GetTasks()
    {
      return null;
    }


  }
}