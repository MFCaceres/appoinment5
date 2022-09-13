using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    //[Keyless]
    public partial class Tblrefreshtoken
    {
        public string UserId { get; set; } = null!;
        public string? TokenId { get; set; }
        public string? Refreshtoken { get; set; }
        public bool? IsActive { get; set; }
    }
}
