using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class ClinicHcp
    {
        public ClinicHcp()
        {
            Hcpslots = new HashSet<Hcpslot>();
        }

        public int ClinicDoctorId { get; set; }
        public bool IsSearchable { get; set; }
        public decimal ClinicPayRate { get; set; }
        public decimal VideoPayRate { get; set; }
        public int? PrimaryclinicProfileId { get; set; }
        public int Hcpid { get; set; }
        public int ClinicProfileId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ClinicProfile ClinicProfile { get; set; } = null!;
        public virtual User Hcp { get; set; } = null!;
        public virtual ICollection<Hcpslot> Hcpslots { get; set; }
    }
}
