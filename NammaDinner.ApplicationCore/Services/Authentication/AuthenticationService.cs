using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NammaDinner.ApplicationCore.Services.Authentication;

public class AuthenticationService: IAuthenticationService
{
    public AuthenticationResult Register(string fistName, string lastName, string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), fistName, lastName, email, "token");
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), "firstName", "lastName", email, "token");
    }
}