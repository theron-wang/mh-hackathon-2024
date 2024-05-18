using DataAccess.Data;
using DataAccess.Models;
using MHHackathon2024.Components;
using MHHackathon2024.ML;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents()
    .AddInteractiveServerComponents();

builder.Services.AddControllers();

builder.Services.AddSingleton<IDatabase, Database>();
builder.Services.AddSingleton<IPasswordHasher, PasswordHasher>();
builder.Services.AddSingleton<ITagData, TagData>();
builder.Services.AddSingleton<IPostData, PostData>();
builder.Services.AddSingleton<IUserStore<User>, UserData>();
builder.Services.AddSingleton<ISummerProgramData, SummerProgramData>();
builder.Services.AddSingleton<IModelReader, ModelReader>();
builder.Services.AddScoped<SignInManager<User>>();

builder.Services.AddOptions();

builder.Services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();

builder.Services.AddOptions();
builder.Services.AddAuthentication()
    .AddCookie(IdentityConstants.ApplicationScheme);

builder.Services.AddAuthorization();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/users/sign-in";
    options.LogoutPath = "/users/sign-out";
    options.SlidingExpiration = true;
    options.ExpireTimeSpan = TimeSpan.FromDays(3);
    options.Cookie.IsEssential = true;
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
});

builder.Services.AddIdentityCore<User>()
    .AddUserStore<UserData>()
    .AddSignInManager<SignInManager<User>>();

builder.Services.AddCascadingAuthenticationState();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode();

app.MapControllers();

app.Run();
