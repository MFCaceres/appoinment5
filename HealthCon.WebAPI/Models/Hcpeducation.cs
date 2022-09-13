using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Hcpeducation
    {
        public int HcpeducationId { get; set; }
        public string? HospitalAffiliation { get; set; }
        public string? MedicalAttendedSchoolName { get; set; }
        public DateTime? GraduationYear { get; set; }
        public string? ResidencyFocus { get; set; }
        public string? ProfessionalMembership { get; set; }
        public string? AwardCertification { get; set; }
        public string? MedicalDegree { get; set; }
        public string? ResidencyLocation { get; set; }
        public string? ResidenceCity { get; set; }
        public int Hcpid { get; set; }
        public int GraduatedCountryId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual Country GraduatedCountry { get; set; } = null!;
        public virtual User Hcp { get; set; } = null!;
    }
}
