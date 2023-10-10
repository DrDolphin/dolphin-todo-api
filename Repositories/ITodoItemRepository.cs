using DolphinTodoWebAPI.Models;

public interface ITodoItemRepository
{
    public Task<TodoItem> CreateTodoItem(TodoItem newTask);
    public Task<TodoItem?> GetTodoItemById(int id);
}