namespace Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResponse Login(string email, string password)
    {
        return new AuthenticationResponse(Guid.NewGuid(), FirstName: "firstName", LastName: "lastName", Email: email, Token: "token");
    }

    public AuthenticationResponse Register(string firstName, string lastName, string email, string password)
    {
        return new AuthenticationResponse(Guid.NewGuid(), FirstName: firstName, LastName: lastName, Email: email, Token: "token");
    }
}
