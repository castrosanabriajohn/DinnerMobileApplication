using Application.Services.Authentication;
using Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;
using AuthenticationResponse = Contracts.Authentication.AuthenticationResponse;

namespace Api.Controllers;

[ApiController]
[Route(template: "auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService) => _authenticationService = authenticationService;

    [HttpPost(template: "register")]
    public IActionResult Register(RegisterRequest request)
    {
        Application.Services.Authentication.AuthenticationResponse authenticationResponseFromService = _authenticationService.Register(
            firstName: request.FirstName,
            lastName: request.LastName,
            email: request.Email,
            password: request.Password);

        // Map record from Application.Services
        AuthenticationResponse response = new(
            Id: authenticationResponseFromService.Id,
            FirstName: authenticationResponseFromService.FirstName,
            LastName: authenticationResponseFromService.LastName,
            Email: authenticationResponseFromService.Email,
            Token: authenticationResponseFromService.Token);

        return Ok(value: response);
    }

    [HttpPost(template: "login")]
    public IActionResult Login(LoginRequest request)
    {
        Application.Services.Authentication.AuthenticationResponse authenticationResponseFromService = _authenticationService.Login(
            email: request.Email,
            password: request.Password);

        AuthenticationResponse response = new(
            Id: authenticationResponseFromService.Id,
            FirstName: authenticationResponseFromService.FirstName,
            LastName: authenticationResponseFromService.LastName,
            Email: authenticationResponseFromService.Email,
            Token: authenticationResponseFromService.Token);

        return Ok(value: response);
    }
}
