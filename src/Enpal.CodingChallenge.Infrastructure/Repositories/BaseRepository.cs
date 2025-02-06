using System.Data;
using Npgsql;

namespace Enpal.CodingChallenge.Infrastructure.Repositories;

public class BaseRepository
{
    private readonly string _connectionString;
    protected IDbConnection Connection => new NpgsqlConnection(_connectionString);

    protected BaseRepository(string connectionString)
    {
        _connectionString = connectionString;
    }
}