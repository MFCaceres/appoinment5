using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class User
    {
        public User()
        {
            Addresses = new HashSet<Address>();
            Allergies = new HashSet<Allergy>();
            Appointments = new HashSet<Appointment>();
            ClinicAdminMaps = new HashSet<ClinicAdminMap>();
            ClinicHcps = new HashSet<ClinicHcp>();
            Diagnoses = new HashSet<Diagnosis>();
            HcpboardCertifications = new HashSet<HcpboardCertification>();
            Hcpeducations = new HashSet<Hcpeducation>();
            Hcpprofiles = new HashSet<Hcpprofile>();
            Hcpslots = new HashSet<Hcpslot>();
            Hcpspecializations = new HashSet<Hcpspecialization>();
            Hcpsuffixes = new HashSet<Hcpsuffix>();
            LoginAudits = new HashSet<LoginAudit>();
            Medications = new HashSet<Medication>();
            Members = new HashSet<Member>();
            PayRates = new HashSet<PayRate>();
            Reports = new HashSet<Report>();
            UserLanguages = new HashSet<UserLanguage>();
        }

        public int UserId { get; set; }
        public string? UserLoginId { get; set; }
        public string Email { get; set; } = null!;
        public int? SecurityQuestionId { get; set; }
        public string? SecurityAnswer { get; set; }
        public string? Salutation { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string Gender { get; set; } = null!;
        public DateTime Dob { get; set; }
        public string? ProfileImagePath { get; set; }
        public DateTime LastActivity { get; set; }
        public DateTime? LastPasswordChange { get; set; }
        public DateTime? LastLockout { get; set; }
        public int? AccessFailedCount { get; set; }
        public int? FailedAnswerAttempts { get; set; }
        public bool IsFirstLogIn { get; set; }
        public bool IsAgreedToTerms { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsLocked { get; set; }
        public bool IsApproved { get; set; }
        public bool? IsOnline { get; set; }
        public DateTime RegisteredDate { get; set; }
        public DateTime? VerifiedDate { get; set; }
        public int UserTypeId { get; set; }
        public int? TimeZoneId { get; set; }
        public string? VerificationCode { get; set; }
        public string? Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }
        public string? PayPalEmail { get; set; }

        public virtual SecurityQuestion? SecurityQuestion { get; set; }
        public virtual TimeZone? TimeZone { get; set; }
        public virtual UserType UserType { get; set; } = null!;
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Allergy> Allergies { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<ClinicAdminMap> ClinicAdminMaps { get; set; }
        public virtual ICollection<ClinicHcp> ClinicHcps { get; set; }
        public virtual ICollection<Diagnosis> Diagnoses { get; set; }
        public virtual ICollection<HcpboardCertification> HcpboardCertifications { get; set; }
        public virtual ICollection<Hcpeducation> Hcpeducations { get; set; }
        public virtual ICollection<Hcpprofile> Hcpprofiles { get; set; }
        public virtual ICollection<Hcpslot> Hcpslots { get; set; }
        public virtual ICollection<Hcpspecialization> Hcpspecializations { get; set; }
        public virtual ICollection<Hcpsuffix> Hcpsuffixes { get; set; }
        public virtual ICollection<LoginAudit> LoginAudits { get; set; }
        public virtual ICollection<Medication> Medications { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<PayRate> PayRates { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<UserLanguage> UserLanguages { get; set; }
    }
}
