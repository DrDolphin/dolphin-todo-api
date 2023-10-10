using DolphinTodoWebAPI.Models;
using Microsoft.EntityFrameworkCore;

public class TodoItemRepository : ITodoItemRepository
{
    private readonly AppDbContext _context;

    public TodoItemRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<TodoItem> CreateTodoItem(TodoItem newTask)
    {
        _context.TodoItems.Add(newTask);
        await _context.SaveChangesAsync();
        return newTask;
    }

    public async Task<TodoItem?> GetTodoItemById(int id)
    {   
        var item = await _context.TodoItems.Where(x => x.Id == id).FirstOrDefaultAsync();
        return item;
    }
}