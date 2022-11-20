using CleanArchitectureApp.Application.Common.Interfaces;

namespace CleanArchitectureApp.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
