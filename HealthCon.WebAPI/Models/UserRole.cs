using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class UserRole
    {
        public string UserRoleId { get; set; } = null!;
        public string RoleId { get; set; } = null!;
        public string? IdentityUserId { get; set; }

        public virtual UserLogin? IdentityUser { get; set; }
        public virtual Role Role { get; set; } = null!;
    }
}
