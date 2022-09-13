using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class ClinicProfile
    {
        public ClinicProfile()
        {
            Addresses = new HashSet<Address>();
            ClinicAdminMaps = new HashSet<ClinicAdminMap>();
            ClinicHcps = new HashSet<ClinicHcp>();
            ClinicOfficeHours = new HashSet<ClinicOfficeHour>();
            ClinicProfileImageFilePaths = new HashSet<ClinicProfileImageFilePath>();
            ClinicSpecialities = new HashSet<ClinicSpeciality>();
            Hcpslots = new HashSet<Hcpslot>();
            PayRates = new HashSet<PayRate>();
        }

        public int ClinicprofileId { get; set; }
        public string ClinicName { get; set; } = null!;
        public string BuisnessLicenseNo { get; set; } = null!;
        public string? Status { get; set; }
        public DateTime? LicenseExpiration { get; set; }
        public string? MedicalAffiliation { get; set; }
        public string? InsuranceAccepted { get; set; }
        public bool IsSearchable { get; set; }
        public bool? IsTrial { get; set; }
        public DateTime? TrialStartDate { get; set; }
        public DateTime? TrialEndDate { get; set; }
        public int? PrimaryClinicId { get; set; }
        public long BuisnessPhoneNo { get; set; }
        public long OfficeAdminNo { get; set; }
        public long BuisnessFaxNo { get; set; }
        public string? OfficeAdminName { get; set; }
        public string? ClinicHours { get; set; }
        public int? TimezoneId { get; set; }
        public int ClinicTypeId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }
        public int? LicenseStateId { get; set; }
        public string? AboutUs { get; set; }

        public virtual ClinicType ClinicType { get; set; } = null!;
        public virtual State? LicenseState { get; set; }
        public virtual TimeZone? Timezone { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<ClinicAdminMap> ClinicAdminMaps { get; set; }
        public virtual ICollection<ClinicHcp> ClinicHcps { get; set; }
        public virtual ICollection<ClinicOfficeHour> ClinicOfficeHours { get; set; }
        public virtual ICollection<ClinicProfileImageFilePath> ClinicProfileImageFilePaths { get; set; }
        public virtual ICollection<ClinicSpeciality> ClinicSpecialities { get; set; }
        public virtual ICollection<Hcpslot> Hcpslots { get; set; }
        public virtual ICollection<PayRate> PayRates { get; set; }
    }
}
