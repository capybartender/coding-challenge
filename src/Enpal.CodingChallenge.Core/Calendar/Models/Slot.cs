﻿namespace Enpal.CodingChallenge.Core.Calendar.Models;

public record Slot
{
    public int AvailableCount { get; }
    public DateTimeOffset StartDate { get; }

    public Slot(int availableCount, DateTimeOffset startDate)
    {
        AvailableCount = availableCount;
        StartDate = startDate;
    }
}