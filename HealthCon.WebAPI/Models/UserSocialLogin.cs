using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class UserSocialLogin
    {
        public string LoginProvider { get; set; } = null!;
        public string ProviderKey { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string? IdentityUserId { get; set; }

        public virtual UserLogin? IdentityUser { get; set; }
    }
}
