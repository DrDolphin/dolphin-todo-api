using DolphinTodoWebAPI.Models;

public interface ITodoItemService {
    public Task<TodoItem> CreateTodoItem(TodoItem item);
    public Task<TodoItem?> GetTodoItemById(int id);
}