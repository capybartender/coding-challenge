namespace Enpal.CodingChallenge.Infrastructure.Tests.TestDataGenerators;

public sealed record InputParameters(DateOnly Date, IEnumerable<string> Products, string Language, string Rating);