using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Hcpprofile
    {
        public int HcpprofileId { get; set; }
        public string? PracticeName { get; set; }
        public int? HitCount { get; set; }
        public long Npi { get; set; }
        public DateTime LicenseExpireDate { get; set; }
        public DateTime? PractisingSince { get; set; }
        public string? HcpprofileImageUrl { get; set; }
        public string? AboutUs { get; set; }
        public string? InsuranceName { get; set; }
        public bool IsSearchable { get; set; }
        public bool? IsPublic { get; set; }
        public bool IsTrial { get; set; }
        public float? AverageRating { get; set; }
        public bool IsNpiapproved { get; set; }
        public DateTime? TrialStartDate { get; set; }
        public DateTime? TrialEndDate { get; set; }
        public int? TrialCount { get; set; }
        public int? TimeZoneId { get; set; }
        public int? LicenseStateId { get; set; }
        public int Hcpid { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual User Hcp { get; set; } = null!;
        public virtual State? LicenseState { get; set; }
        public virtual TimeZone? TimeZone { get; set; }
    }
}
