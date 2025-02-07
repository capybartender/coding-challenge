﻿using Enpal.CodingChallenge.Core.Calendar.Models;
using Enpal.CodingChallenge.Infrastructure.Models;

namespace Enpal.CodingChallenge.Infrastructure.Mappings;

public static class MappingExtensions
{
    private static Slot ToCoreModel(this SlotDalModel slot) 
        => new(slot.AvailableCount, slot.StartDate);

    public static Slot[] ToCoreModels(this IEnumerable<SlotDalModel> slots)
        => slots.Select(slot => slot.ToCoreModel()).ToArray();
}