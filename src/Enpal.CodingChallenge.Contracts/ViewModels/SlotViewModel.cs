namespace Enpal.CodingChallenge.Contracts.ViewModels;

public sealed record SlotViewModel
{
    public int AvailableCount { get; }
    public DateTime StartDate { get; }

    public SlotViewModel(int availableCount, DateTimeOffset startDate)
    {
        AvailableCount = availableCount;
        StartDate = startDate.UtcDateTime;
    }
}