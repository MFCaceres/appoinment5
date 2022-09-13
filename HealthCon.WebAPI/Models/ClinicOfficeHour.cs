using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class ClinicOfficeHour
    {
        public int ClinicOfficeHourId { get; set; }
        public string Day { get; set; } = null!;
        public TimeSpan FromTime { get; set; }
        public TimeSpan ToTime { get; set; }
        public int ClinicProfileId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual ClinicProfile ClinicProfile { get; set; } = null!;
    }
}
