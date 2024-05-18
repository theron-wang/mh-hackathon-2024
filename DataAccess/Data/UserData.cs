using DataAccess.Models;
using Microsoft.AspNetCore.Identity;

namespace DataAccess.Data;
public class UserData(IDatabase dataAccess) : IUserStore<User>
{
    private readonly IDatabase _dataAccess = dataAccess;

    public async Task<IdentityResult> CreateAsync(User user, CancellationToken cancellationToken)
    {
        if ((await _dataAccess.GetSingle<User>("spUsers_GetByUsername", new { user.Username })) is not null)
        {
            return IdentityResult.Failed(new IdentityError { Code = "UsernameExists", Description = "Username already exists" });
        }
        else if ((await _dataAccess.GetSingle<User>("spUsers_GetByEmail", new { user.Email })) is not null)
        {
            return IdentityResult.Failed(new IdentityError { Code = "EmailExists", Description = "Email already exists" });
        }

        await _dataAccess.Set("spUsers_Create", new { user.Username, user.Email, user.PasswordHash, Industry = user.Industry!.Id });

        return IdentityResult.Success;
    }

    public async Task<IdentityResult> DeleteAsync(User user, CancellationToken cancellationToken)
    {
        await _dataAccess.Set("spUsers_Delete", new { user.Id });

        return IdentityResult.Success;
    }

    public void Dispose()
    {
    }

    public async Task<User?> FindByIdAsync(string userId, CancellationToken cancellationToken)
    {
        return (await _dataAccess.GetAsync<User, User, Tag>("spUsers_GetById", new { Id = userId }, (u, t) =>
        {
            u.Industry = t;
            return u;
        })).FirstOrDefault();
    }

    public async Task<User?> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
    {
        return (await _dataAccess.GetAsync<User, User, Tag>("spUsers_GetByUsername", new { Username = normalizedUserName }, (u, t) =>
        {
            u.Industry = t;
            return u;
        })).FirstOrDefault();
    }

    public Task<string?> GetNormalizedUserNameAsync(User user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user.Username);
    }

    public Task<string> GetUserIdAsync(User user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user.Id!.ToString());
    }

    public Task<string?> GetUserNameAsync(User user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user.Username);
    }

    public Task SetNormalizedUserNameAsync(User user, string? normalizedName, CancellationToken cancellationToken)
    {
        user.Username = normalizedName;
        return Task.CompletedTask;
    }

    public Task SetUserNameAsync(User user, string? userName, CancellationToken cancellationToken)
    {
        user.Username = userName;
        return Task.CompletedTask;
    }

    public async Task<IdentityResult> UpdateAsync(User user, CancellationToken cancellationToken)
    {
        await _dataAccess.Set("spUsers_Update", new { user.Id, user.Username, user.Email, Industry = user.Industry!.Id });
        return IdentityResult.Success;
    }
}
