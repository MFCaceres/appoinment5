using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Hcpslot
    {
        public Hcpslot()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int HcpslotId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string AvailabiltyMode { get; set; } = null!;
        public int ClinicHcpid { get; set; }
        public int Hcpid { get; set; }
        public int TimeZoneId { get; set; }
        public int ClinicProfileId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }
        public string? ClinicName { get; set; }
        public bool? IsBooked { get; set; }

        public virtual ClinicHcp ClinicHcp { get; set; } = null!;
        public virtual ClinicProfile ClinicProfile { get; set; } = null!;
        public virtual User Hcp { get; set; } = null!;
        public virtual TimeZone TimeZone { get; set; } = null!;
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
