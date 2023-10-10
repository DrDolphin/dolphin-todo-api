using DolphinTodoWebAPI.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

[ApiController]
[Route("api/task")]
public class ToDoItemController : ControllerBase
{
    private readonly ITodoItemService _todoItemService;

    public ToDoItemController(ITodoItemService todoItemService){
        _todoItemService = todoItemService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TodoItem>> GetTodoItemById(int id) {
        var retievedTodoItem = await _todoItemService.GetTodoItemById(id);

        if (retievedTodoItem == null)
        {
            return NotFound();
        }

        return Ok(retievedTodoItem);
    }

    [HttpPost]
    public async Task<ActionResult<TodoItem>> CreateTodoItem(TodoItem newTask)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var createdToDoItem = await _todoItemService.CreateTodoItem(newTask);
        return CreatedAtAction(nameof(GetTodoItemById), new { id = createdToDoItem.Id }, createdToDoItem);
    }
}