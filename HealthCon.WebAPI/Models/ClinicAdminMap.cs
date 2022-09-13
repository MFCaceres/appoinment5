using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class ClinicAdminMap
    {
        public int ClinicAdminMapId { get; set; }
        public int? PrimaryClinicProfileId { get; set; }
        public int ClinicId { get; set; }
        public int AdminId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual User Admin { get; set; } = null!;
        public virtual ClinicProfile Clinic { get; set; } = null!;
    }
}
