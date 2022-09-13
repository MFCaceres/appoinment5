using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class LoginAudit
    {
        public int LoginAuditId { get; set; }
        public DateTime LogInTime { get; set; }
        public DateTime? LogOutTime { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
