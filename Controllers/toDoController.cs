using System; 
using Microsoft.AspNetCore.Mvc;
using demoApp.Models;

//Which folder its in
namespace demoApp.Controllers;

public class HomeController : Controller
{
  //Make a list for testing purposes
  private static List<toDoItem> toDos = new List<toDoItem>();
  //Index is the first thing thats shown when opened, here i just show a list that was made 
  public IActionResult Index()
  {
    return View(toDos);
  }

  //Functionality to the Add button, HttpPost means that this is only for posting so client -> server
  [HttpPost]
  public IActionResult Add(toDoItem newToDo)
  {
    if(toDos.Count > 0){
      newToDo.Id = toDos.Count+1;
    }
    else{
      newToDo.Id = 1;
    }
    toDos.Add(newToDo);
    return RedirectToAction("Index");
  }

  public IActionResult Complete(int id){
    foreach(var todo in toDos){
      if(todo.Id == id){
        todo.IsCompleted = true;
        break;
      }
    }
    return RedirectToAction("Index");
  }
}
