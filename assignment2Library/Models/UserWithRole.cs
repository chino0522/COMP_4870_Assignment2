using Microsoft.AspNetCore.Identity;

namespace assignment2Library.Models;
public class UserWithRole
{
        public IdentityUser? User { get; set; }
        public IList<string> Roles { get; set; } = new List<string>();
        
}
