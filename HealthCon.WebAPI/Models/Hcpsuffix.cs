using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Hcpsuffix
    {
        public int HcpsuffixId { get; set; }
        public int Hcpid { get; set; }
        public int SuffixId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual User Hcp { get; set; } = null!;
        public virtual Suffix Suffix { get; set; } = null!;
    }
}
