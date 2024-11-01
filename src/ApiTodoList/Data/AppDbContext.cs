using Dc.ApiTodoList.Models;
using Microsoft.EntityFrameworkCore;

namespace Dc.ApiTodoList.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; }

}
