using Enpal.CodingChallenge.Contracts.ViewModels;
using Enpal.CodingChallenge.Core.Calendar.Models;

namespace Enpal.CodingChallenge.Api.Mappings;

public static class MappingExtensions
{
    private static SlotViewModel ToViewModel(this Slot slot) 
        => new(slot.AvailableCount, slot.StartDate);

    public static SlotViewModel[] ToViewModels(this IEnumerable<Slot> slots)
        => slots.Select(slot => slot.ToViewModel()).ToArray();
}