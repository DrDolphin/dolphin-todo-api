using DolphinTodoWebAPI.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {
        
    }

    public DbSet<TodoItem>? TodoItem { get; set; }
    public DbSet<User>? User { get; set; } 
}