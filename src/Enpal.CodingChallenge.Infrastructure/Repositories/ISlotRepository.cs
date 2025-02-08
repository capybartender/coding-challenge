using Enpal.CodingChallenge.Infrastructure.Models;

namespace Enpal.CodingChallenge.Infrastructure.Repositories;

public interface ISlotRepository
{
    Task<SlotDalModel[]> GetAvailableSlotsAsync(
        DateOnly date,
        IEnumerable<string> products,
        string language,
        string rating,
        CancellationToken ct);
}