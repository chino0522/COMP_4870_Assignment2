using Microsoft.AspNetCore.Identity;

namespace assignment2Library.Models;
public class User : IdentityUser
{
    public User() : base() { }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public static implicit operator string?(User? v)
    {
        throw new NotImplementedException();
    }
}
