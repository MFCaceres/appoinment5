using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Language
    {
        public Language()
        {
            UserLanguages = new HashSet<UserLanguage>();
        }

        public int LanguageId { get; set; }
        public string LanguageName { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual ICollection<UserLanguage> UserLanguages { get; set; }
    }
}
