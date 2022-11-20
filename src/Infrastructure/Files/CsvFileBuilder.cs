using System.Globalization;
using CleanArchitectureApp.Application.Common.Interfaces;
using CleanArchitectureApp.Application.TodoLists.Queries.ExportTodos;
using CleanArchitectureApp.Infrastructure.Files.Maps;
using CsvHelper;

namespace CleanArchitectureApp.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
