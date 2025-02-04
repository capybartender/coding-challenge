using Enpal.CodingChallenge.Contracts.ViewModels;
using Enpal.CodingChallenge.Core.Calendar.Models;

namespace Enpal.CodingChallenge.Api.Mappings;

public static class MappingExtensions
{
    private static SlotViewModel ToSlotViewModel(this Slot slot) 
        => new(slot.AvailableCount, slot.StartDate);

    public static IEnumerable<SlotViewModel> ToSlotViewModels(this IEnumerable<Slot> slots)
        => slots.Select(slot => slot.ToSlotViewModel());
}