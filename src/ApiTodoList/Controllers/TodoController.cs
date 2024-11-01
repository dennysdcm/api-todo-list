using Dc.ApiTodoList.Interfaces;
using Dc.ApiTodoList.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiTodoList.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    private readonly ITodoService _todoService;

    public TodoController(ITodoService todoService)
    {
        _todoService = todoService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _todoService.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var todo = await _todoService.GetByIdAsync(id);
        if (todo == null) return NotFound();

        return Ok(todo);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody]TodoItem todo)
    {
        var createdTodo = await _todoService.AddAsync(todo);

        return CreatedAtAction(nameof(Get), new { id = createdTodo.Id }, createdTodo);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody]TodoItem todo)
    {
        todo.Id = id;
        var updatedTodo = await _todoService.UpdateAsync(todo);

        return Ok(updatedTodo);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await _todoService.DeleteAsync(id));
    }
}
