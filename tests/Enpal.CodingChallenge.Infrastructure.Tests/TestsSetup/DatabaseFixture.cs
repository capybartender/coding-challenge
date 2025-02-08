using JetBrains.Annotations;
using Testcontainers.PostgreSql;

namespace Enpal.CodingChallenge.Infrastructure.Tests.TestsSetup;

[UsedImplicitly]
public sealed class DatabaseFixture : BaseTestcontainersTests
{
    internal new PostgreSqlContainer Postgres => base.Postgres;

}