namespace Enpal.CodingChallenge.Contracts.ViewModels;

public record SlotViewModel
{
    public int AvailableCount { get; }
    public DateTime StartDate { get; }

    public SlotViewModel(int availableCount, DateTimeOffset startDate)
    {
        AvailableCount = availableCount;
        StartDate = startDate.UtcDateTime;
    }
// "available_count": 2,
// "start_date": "2024-05-03T12:00:00.00Z"
}