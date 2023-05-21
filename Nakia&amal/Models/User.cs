using Microsoft.AspNetCore.Identity;

namespace Nakia_amal.Models
{
    public class User :IdentityUser<int>
    {
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public virtual ICollection<Reclamation> Reclamations { get; set; } = new List<Reclamation>();
    }
}
