using DataAccess.Models;

namespace DataAccess.Data;
public interface IPostData
{
    Task CreatePost(Post post);
    Task DeletePost(Post post);
    Task DeleteResponse(Response response);
    Task EditResponse(Response response);
    Task<Post?> GetPost(int id);
    Task<List<Post>> GetPosts();
    Task ReplyToPost(Post post, Response response);
    Task UpdatePost(Post post);
}