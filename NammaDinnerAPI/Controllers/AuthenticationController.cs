using Microsoft.AspNetCore.Mvc;
using NammaDinner.Contracts.Authentication;

namespace NammaDinnerAPI.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticatinoController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        return Ok(request);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        return Ok(request);
    }
}