using Microsoft.AspNetCore.Identity;

namespace Nakia_amal.Models
{
    public class Role :IdentityRole<int>
    {
        public ICollection<User> Users { get; set; }
    }
}
