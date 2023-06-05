using Microsoft.AspNetCore.Identity;

namespace WebApp2.Entities
{
    public class AppUser : IdentityUser
    {
        public string? FriendId { get; set; }
        public AppUser? Friend { get; set; }
        public ICollection<AppUser>? Friends { get; set; }
    }
}
