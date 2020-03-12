using TodoList.Data;
// using System.Linq;

namespace TodoList.Services
{
  public class TaskService
  {
    private ApplicationDbContext _context;

    public TaskService(ApplicationDbContext context)
    {
      this._context = context;
    }
  }
}