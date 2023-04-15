namespace Application.Services.Authentication;

public record AuthenticationResponse(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token
);

public interface IAuthenticationService
{
    AuthenticationResponse Register(string firstName, string lastName, string email, string password);
    AuthenticationResponse Login(string email, string password);
}
