
namespace MHHackathon2024.ML;

public interface IModelReader
{
    Task<string> GetRecommendedField(List<int> input);
}