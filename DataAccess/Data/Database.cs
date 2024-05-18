using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DataAccess.Data;
public class Database(IConfiguration config) : IDatabase
{
    private readonly IConfiguration _config = config;

    public async Task<T?> GetSingle<T>(string procedure, object parameters)
    {
        using var connection = new SqlConnection(_config.GetConnectionString("Default"));
        return await connection.QueryFirstOrDefaultAsync<T>(procedure, parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task<IEnumerable<T>> GetMany<T>(string procedure, object parameters)
    {
        using var connection = new SqlConnection(_config.GetConnectionString("Default"));
        return await connection.QueryAsync<T>(procedure, parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task<List<T>> GetAsync<T, TFirst, TSecond>(string storedProcedure, object parameters, Func<TFirst, TSecond, T> map, string splitOn = "Id")
    {
        using var connection = new SqlConnection(_config.GetConnectionString("Default"));

        var result = await connection.QueryAsync(storedProcedure, map, parameters, splitOn: splitOn, commandType: CommandType.StoredProcedure);
        return result.ToList();
    }

    public async Task<List<T>> GetAsync<T, TFirst, TSecond, TThird>(string storedProcedure, object parameters, Func<TFirst, TSecond, TThird, T> map, string splitOn = "Id")
    {
        using var connection = new SqlConnection(_config.GetConnectionString("Default"));

        var result = await connection.QueryAsync(storedProcedure, map, parameters, splitOn: splitOn, commandType: CommandType.StoredProcedure);
        return result.ToList();
    }

    public async Task Set(string procedure, object parameters)
    {
        using var connection = new SqlConnection(_config.GetConnectionString("Default"));
        await connection.ExecuteAsync(procedure, parameters, commandType: CommandType.StoredProcedure);
    }
}
