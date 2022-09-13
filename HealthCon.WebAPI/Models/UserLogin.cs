using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class UserLogin
    {
        public UserLogin()
        {
            UserClaims = new HashSet<UserClaim>();
            UserRoles = new HashSet<UserRole>();
            UserSocialLogins = new HashSet<UserSocialLogin>();
        }

        public string Id { get; set; } = null!;
        public string? Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string? PasswordHash { get; set; }
        public string? SecurityStamp { get; set; }
        public string? PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string? UserName { get; set; }

        public virtual AspNetUser AspNetUser { get; set; } = null!;
        public virtual ICollection<UserClaim> UserClaims { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<UserSocialLogin> UserSocialLogins { get; set; }
    }
}
