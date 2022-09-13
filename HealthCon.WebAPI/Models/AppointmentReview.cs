using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class AppointmentReview
    {
        public int AppointmentReviewId { get; set; }
        public decimal? HcpsoundVideoQuality { get; set; }
        public decimal? HcpdocCareExperience { get; set; }
        public string? Hcpcomment { get; set; }
        public decimal? PatientSoundVideoQuality { get; set; }
        public int? Hcprating { get; set; }
        public string? PatientComment { get; set; }
        public int AppointmentId { get; set; }
        public int Hcpid { get; set; }
        public int PatientId { get; set; }
        public string? PatientName { get; set; }
        public string? Hcpname { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual Appointment Appointment { get; set; } = null!;
    }
}
