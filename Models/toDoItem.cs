using System;

namespace demoApp.Models{
    public class toDoItem{
  public int Id { get; set;}
  public required string Title{ get; set;}
  public bool IsCompleted{ get; set;}
  public DateTime dueDate{ get; set;}
  
  public TimeOnly dueTime{ get; set;}
    }
}