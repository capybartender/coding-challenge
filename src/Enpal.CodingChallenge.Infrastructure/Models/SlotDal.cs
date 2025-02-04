namespace Enpal.CodingChallenge.Infrastructure.Models;

public sealed record SlotDal
{
    public int AvailableCount { get; set; }
    public DateTimeOffset StartDate { get; set; }
}