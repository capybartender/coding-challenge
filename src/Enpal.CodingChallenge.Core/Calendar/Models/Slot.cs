namespace Enpal.CodingChallenge.Core.Calendar.Models;

public sealed record Slot
{
    public int AvailableCount { get; }
    public DateTimeOffset StartDate { get; }

    public Slot(int availableCount, DateTimeOffset startDate)
    {
        AvailableCount = availableCount;
        StartDate = startDate;
    }
}