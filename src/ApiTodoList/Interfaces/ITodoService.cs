using Dc.ApiTodoList.Models;

namespace Dc.ApiTodoList.Interfaces;

public interface ITodoService
{
    Task<IEnumerable<TodoItem>> GetAllAsync();
    Task<TodoItem?> GetByIdAsync(int id);
    Task<TodoItem> AddAsync(TodoItem item);
    Task<TodoItem> UpdateAsync(TodoItem item);
    Task<bool> DeleteAsync(int id);
}
