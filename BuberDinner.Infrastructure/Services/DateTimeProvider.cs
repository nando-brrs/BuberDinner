using BuberDinner.Application.Common.Interfaces.Services;

namespace BuberDinner.Infrastruture.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}