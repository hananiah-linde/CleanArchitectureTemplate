using CleanArchitectureApp.Application.TodoLists.Queries.ExportTodos;

namespace CleanArchitectureApp.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
