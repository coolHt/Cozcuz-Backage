using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ht_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ht_project.Controllers {
  [Route ("api/[controller]")]
  [ApiController]
  public class TodoController : ControllerBase {
    private readonly TodoContext _context;

    public TodoController (TodoContext context) {
      _context = context;

      if (_context.TodoItems.Count () == 0) {
        // Create a new TodoItem if collection is empty,
        // which means you can't delete all TodoItems.
        _context.TodoItems.Add (new TodoItem { Name = "Item1" });
        _context.SaveChanges ();
      }
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems () {
      return await _context.TodoItems.ToListAsync ();
    }

    // GET: api/Todo/5
    [HttpGet ("{id}")]
    public async Task<ActionResult<TodoItem>> GetTodoItem (long id) {
      var todoItem = await _context.TodoItems.FindAsync (id);

      if (todoItem == null) {
        return NotFound ();
      }

      return todoItem;
    }

    [HttpPost]
    public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem item){
      _context.TodoItems.Add(item);
      await _context.SaveChangesAsync();

      return CreatedAtAction(nameof(GetTodoItem), new {id = item.Id}, item);
    }
  }
}