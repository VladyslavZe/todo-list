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

    [HttpPost]
    public Task CreateTask(Task task)
    {
      return _taskService.Create(task);
    }

    [HttpGet]
    public List<Task> GetTasks()
    {
      return _taskService.Get();
    }

    [HttpDelete]
    public void DeleteTasks()
    {
      _taskService.DeleteAll();
    }

    [HttpGet("{id}")]
    public ActionResult GetTaskById(int id)
    {
      Task taskId = _taskService.GetById(id);
      if (taskId == null)
      {
        return NotFound();
      }
      return Ok(taskId);
    }

    [HttpDelete("{id}")]
    public void DeleteTaskById(int id)
    {
      _taskService.DeleteById(id);
    }

    [HttpPut("{id}")]
    public void PutTask(int id, Task task)
    {
      _taskService.Put(id, task);
    }
  }
}