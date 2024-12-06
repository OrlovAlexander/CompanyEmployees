using Microsoft.AspNetCore.Identity;

namespace CompanyEmployees.Authentication;

public class AppUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
