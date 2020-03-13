using TodoList.Data;
using TodoList.Models;
using System.Collections.Generic;
using System.Linq;

namespace TodoList.Services
{
  public class TaskService
  {
    private ApplicationDbContext _context;

    public TaskService(ApplicationDbContext context)
    {
      this._context = context;
    }

    public Task Create(Task task)
    {
      _context.Tasks.Add(task);
      _context.SaveChanges();
      return task;
    }

    public List<Task> Get()
    {
      return _context.Tasks.ToList();
    }

    public void DeleteAll()
    {
      _context.Tasks.RemoveRange(_context.Tasks.ToList());
      _context.SaveChanges();
    }
  }
}