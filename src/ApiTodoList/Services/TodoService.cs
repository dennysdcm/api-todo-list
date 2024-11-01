using Dc.ApiTodoList.Data;
using Dc.ApiTodoList.Interfaces;
using Dc.ApiTodoList.Models;
using Microsoft.EntityFrameworkCore;

namespace Dc.ApiTodoList.Services;

public class TodoService : ITodoService
{
    private readonly AppDbContext _context;

    public TodoService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<TodoItem> AddAsync(TodoItem item)
    {
        _context.TodoItems.Add(item);
        await _context.SaveChangesAsync();

        return item;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var todo = await _context.TodoItems.FindAsync(id);
        if (todo == null) return false;

        _context.TodoItems.Remove(todo);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<IEnumerable<TodoItem>> GetAllAsync()
    {
        return await _context.TodoItems.ToListAsync();
    }

    public async Task<TodoItem?> GetByIdAsync(int id)
    {
        return await _context.TodoItems.FindAsync(id);
    }

    public async Task<TodoItem> UpdateAsync(TodoItem item)
    {
        _context.Entry(item).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return item;
    }
}
