using Microsoft.AspNetCore.Identity;

namespace Hihired.Infrastructure.Security.Identity
{
    public class ApplicationRole : IdentityRole<int>
    {
        public string Description { get; set; }
    }
}
