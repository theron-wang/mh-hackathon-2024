using DataAccess.Models;

namespace DataAccess.Data;
public class PostData(IDatabase dataAccess) : IPostData
{
    private readonly IDatabase _dataAccess = dataAccess;

    public Task<List<Post>> GetPosts()
    {
        var dictionary = new Dictionary<int, Post>();

        return _dataAccess.GetAsync<Post, Post, Response, User, Tag>("spPosts_GetAll", new { }, (post, response, user, tag) =>
        {
            if (dictionary.TryGetValue(post.Id, out var existingPost))
            {
                existingPost.Responses!.Add(response);
                return existingPost;
            }
            post.User = user;
            post.Responses = [];
            post.Responses.Add(response);
            post.User.Industry = tag;

            dictionary[post.Id] = post;

            return post;
        });
    }

    public async Task<Post?> GetPost(int id)
    {
        Post? p = null;

        return (await _dataAccess.GetAsync<Post, Post, Response, User, Tag>("spPosts_GetById", new { Id = id }, (post, response, user, tag) =>
        {
            if (post is null)
            {
                p = post;
            }

            p!.User = user;
            p.User.Industry = tag;
            p.Responses ??= [];
            p.Responses.Add(response);
            return p;
        })).FirstOrDefault();
    }

    public Task CreatePost(Post post)
    {
        return _dataAccess.Set("spPosts_Create", new { post.UserId, post.Text });
    }

    public Task DeletePost(Post post)
    {
        return _dataAccess.Set("spPosts_Delete", new { post.Id });
    }

    public Task UpdatePost(Post post)
    {
        return _dataAccess.Set("spPosts_Update", new { post.Id, post.Text });
    }

    public Task ReplyToPost(Post post, Response response)
    {
        return _dataAccess.Set("spPosts_Reply", new { post.Id, response.UserId, response.Text });
    }

    public Task EditResponse(Response response)
    {
        return _dataAccess.Set("spPosts_EditResponse", new { response.Id, response.Text });
    }

    public Task DeleteResponse(Response response)
    {
        return _dataAccess.Set("spPosts_DeleteResponse", new { response.Id });
    }
}
