using Dapper;
using Enpal.CodingChallenge.Infrastructure.Models;

namespace Enpal.CodingChallenge.Infrastructure.Repositories;

public sealed class SlotRepository : BaseRepository, ISlotRepository
{
    public SlotRepository(string connectionString)
        : base(connectionString)
    {}

    public async Task<SlotDalModel[]> GetAvailableSlotsAsync(
        DateOnly date,
        IEnumerable<string> products,
        string language,
        string rating,
        CancellationToken ct)
    {
        using var connection = Connection;
        connection.Open();

        const string query = """
                             SELECT s.start_date AS StartDate, COUNT(s.id) AS AvailableCount 
                             FROM slots s
                             LEFT JOIN sales_managers sm ON s.sales_manager_id = sm.id
                             WHERE s.booked = false AND 
                                   s.start_date::TIMESTAMP::DATE = @Date::DATE AND
                                   sm.products @> ARRAY [@Products]::varchar[] AND
                                   @Language = ANY(sm.languages) AND
                                   @Rating = ANY(sm.customer_ratings) AND
                                   (SELECT COUNT(id) 
                                     FROM slots
                                     WHERE sales_manager_id = s.sales_manager_id AND
                                     booked = true AND
                                     ((end_date > s.start_date AND end_date <= s.end_date) OR (start_date >= s.start_date AND start_date < s.end_date)) AND 
                                     id != s.id) = 0
                             GROUP BY s.start_date
                             ORDER BY s.start_date
                             """;

        var parameters = new DynamicParameters();
        parameters.Add("@Date", date.ToString("yyyy-MM-dd"));
        parameters.Add("@Products", products.ToArray());
        parameters.Add("@Language", language);
        parameters.Add("@Rating", rating);

        var slots = await connection.QueryAsync<SlotDalModel>(query, parameters);

        return slots.ToArray();
    }
}