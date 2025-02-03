using MediatR;

namespace Enpal.CodingChallenge.Core.Calendar.Queries;

public record TestQuery() : IRequest<string>;