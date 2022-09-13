using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class UserLanguage
    {
        public int UserLanguageId { get; set; }
        public int UserId { get; set; }
        public int LanguageId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual Language Language { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
