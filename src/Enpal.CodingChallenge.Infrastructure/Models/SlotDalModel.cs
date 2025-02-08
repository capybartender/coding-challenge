namespace Enpal.CodingChallenge.Infrastructure.Models;

public sealed record SlotDalModel
{
    public int AvailableCount { get; set; }
    public DateTimeOffset StartDate { get; set; }
}