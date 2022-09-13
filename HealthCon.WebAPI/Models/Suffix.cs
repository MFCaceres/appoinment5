using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Suffix
    {
        public Suffix()
        {
            Hcpsuffixes = new HashSet<Hcpsuffix>();
        }

        public int SuffixId { get; set; }
        public string SuffixName { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual ICollection<Hcpsuffix> Hcpsuffixes { get; set; }
    }
}
