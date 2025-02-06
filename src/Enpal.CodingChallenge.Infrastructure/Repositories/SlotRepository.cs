using Enpal.CodingChallenge.Infrastructure.Models;

namespace Enpal.CodingChallenge.Infrastructure.Repositories;

public class SlotRepository : BaseRepository, ISlotRepository
{
    public SlotRepository(string connectionString)
        : base(connectionString)
    {}

    public Task<SlotDal[]> GetAvailableSlotsAsync(
        DateOnly date,
        IEnumerable<string> products,
        string language,
        string rating,
        CancellationToken ct)
    {
        var slot1 = new SlotDal{AvailableCount = 2, StartDate = DateTimeOffset.UtcNow};
        var slot2 = new SlotDal{AvailableCount = 3, StartDate = DateTimeOffset.UtcNow.AddDays(2)};
        var data = new [] { slot1, slot2 };
        return Task.FromResult(data);
    }
}