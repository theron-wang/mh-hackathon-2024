

namespace DataAccess.Data;

public interface IDatabase
{
    Task<List<T>> GetAsync<T, TFirst, TSecond>(string storedProcedure, object parameters, Func<TFirst, TSecond, T> map, string splitOn = "Id");
    Task<List<T>> GetAsync<T, TFirst, TSecond, TThird>(string storedProcedure, object parameters, Func<TFirst, TSecond, TThird, T> map, string splitOn = "Id");
    Task<IEnumerable<T>> GetMany<T>(string procedure, object parameters);
    Task<T?> GetSingle<T>(string procedure, object parameters);
    Task Set(string procedure, object parameters);
}