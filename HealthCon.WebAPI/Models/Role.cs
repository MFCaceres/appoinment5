using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Role
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public string RoleId { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
