using DataAccess.Models;

namespace DataAccess.Data;
public class TagData(IDatabase dataAccess) : ITagData
{
    private readonly IDatabase _dataAccess = dataAccess;

    public Task<IEnumerable<Tag>> GetAllTags()
    {
        return _dataAccess.GetMany<Tag>("spTags_GetAll", new { });
    }

    public Task AddTag(Tag tag)
    {
        return _dataAccess.Set("spTags_Create", new { tag.Name });
    }
}
