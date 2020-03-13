namespace TodoList.Models
{
  public class Task
  {
    public Task()
    {
    }

    public Task(int id, string name, bool done)
    {
      this.Id = id;
      this.Name = name;
      this.Done = done;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public bool Done { get; set; }

  }
}