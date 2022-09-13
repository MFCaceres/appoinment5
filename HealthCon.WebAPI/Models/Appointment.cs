using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Appointment
    {
        public Appointment()
        {
            AppointmentChats = new HashSet<AppointmentChat>();
            AppointmentNotes = new HashSet<AppointmentNote>();
            AppointmentReviews = new HashSet<AppointmentReview>();
        }

        public int AppointmentId { get; set; }
        public DateTime AppointmentStartTime { get; set; }
        public DateTime AppointmentEndTime { get; set; }
        public string AppointmentReason { get; set; } = null!;
        public string? Status { get; set; }
        public string? AvailabiltyMode { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime AppointmentDuration { get; set; }
        public TimeSpan AppointmentLength { get; set; }
        public DateTime AppointmentBookedOn { get; set; }
        public int AppointmentWith { get; set; }
        public int AppointmentTakenBy { get; set; }
        public int? MemberId { get; set; }
        public int HcpslotId { get; set; }
        public string? AppointmentWithEmail { get; set; }
        public string? AppointmentTakenByEmail { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }
        public bool? IsTermsConditionHcp { get; set; }
        public bool? IsTermsConditionPatient { get; set; }
        public bool? IsAcknowledgeHcp { get; set; }
        public bool? IsAcknowledgePatient { get; set; }
        public bool? IsHcpattained { get; set; }
        public bool? IsPatientAttained { get; set; }
        public bool? HcpnoteStatus { get; set; }
        public int? PrimaryClinicProfileId { get; set; }

        public virtual User AppointmentTakenByNavigation { get; set; } = null!;
        public virtual Hcpslot Hcpslot { get; set; } = null!;
        public virtual Member? Member { get; set; }
        public virtual ICollection<AppointmentChat> AppointmentChats { get; set; }
        public virtual ICollection<AppointmentNote> AppointmentNotes { get; set; }
        public virtual ICollection<AppointmentReview> AppointmentReviews { get; set; }
    }
}
