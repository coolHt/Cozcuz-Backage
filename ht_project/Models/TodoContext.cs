using Microsoft.EntityFrameworkCore;

namespace ht_project.Models {
  public class TodoContext : DbContext {
    public TodoContext(DbContextOptions<TodoContext> options):base(options){

    }
    public DbSet<TodoItem> TodoItems {get; set;}
  }
}