using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MHHackathon2024.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsersController(SignInManager<User> signInManager) : ControllerBase
{
    private readonly SignInManager<User> _signInManager = signInManager;

    [Route("/users/sign-out")]
    public async Task<IActionResult> LogOut()
    {
        await _signInManager.SignOutAsync();
        return LocalRedirect("~/");
    }
}
