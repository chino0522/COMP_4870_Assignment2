using Microsoft.AspNetCore.Identity;

namespace assignment2Libra.Models;
public class Role : IdentityRole
{
    public Role() : base() { }
    public Role(string roleName) : base(roleName) { }
    public Role(string roleName, string description) : base(roleName)
    {
        base.Name = roleName;
        this.Description = description;
    }
    public string? Description { get; set; }
}
