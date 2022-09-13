using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class AspNetUser
    {
        public string Id { get; set; } = null!;

        public virtual UserLogin IdNavigation { get; set; } = null!;
    }
}
