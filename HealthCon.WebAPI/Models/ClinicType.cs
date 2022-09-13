using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class ClinicType
    {
        public ClinicType()
        {
            ClinicProfiles = new HashSet<ClinicProfile>();
        }

        public int ClinicTypeId { get; set; }
        public string ClinicTypeCode { get; set; } = null!;
        public string? ClinicTypeDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual ICollection<ClinicProfile> ClinicProfiles { get; set; }
    }
}
