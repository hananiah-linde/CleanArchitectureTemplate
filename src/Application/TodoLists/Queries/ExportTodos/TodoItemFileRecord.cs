using CleanArchitectureApp.Application.Common.Mappings;
using CleanArchitectureApp.Domain.Entities;

namespace CleanArchitectureApp.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
