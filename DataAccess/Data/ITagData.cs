using DataAccess.Models;

namespace DataAccess.Data;
public interface ITagData
{
    Task AddTag(Tag tag);
    Task<IEnumerable<Tag>> GetAllTags();
}