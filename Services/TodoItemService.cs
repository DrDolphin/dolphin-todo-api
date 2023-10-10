using DolphinTodoWebAPI.Models;

public class TodoItemService : ITodoItemService
{
    private ITodoItemRepository _todoItemRepository;
    public TodoItemService(ITodoItemRepository todoItemRepository) {
        _todoItemRepository = todoItemRepository;
    }
    public async Task<TodoItem> CreateTodoItem(TodoItem item)
    {
        return await _todoItemRepository.CreateTodoItem(item);
    }

    public async Task<TodoItem?> GetTodoItemById(int id)
    {
        return await _todoItemRepository.GetTodoItemById(id);
    }
}