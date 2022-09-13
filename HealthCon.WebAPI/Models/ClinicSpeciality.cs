using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class ClinicSpeciality
    {
        public int ClinicSpecialityId { get; set; }
        public int ClinicProfileId { get; set; }
        public int SpecialityId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual ClinicProfile ClinicProfile { get; set; } = null!;
        public virtual Speciality Speciality { get; set; } = null!;
    }
}
