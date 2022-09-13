using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class TimeZone
    {
        public TimeZone()
        {
            ClinicProfiles = new HashSet<ClinicProfile>();
            Hcpprofiles = new HashSet<Hcpprofile>();
            Hcpslots = new HashSet<Hcpslot>();
            Users = new HashSet<User>();
        }

        public int TimeZoneId { get; set; }
        public string TimeZoneName { get; set; } = null!;
        public float Offset { get; set; }
        public float DayNightSaving { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual ICollection<ClinicProfile> ClinicProfiles { get; set; }
        public virtual ICollection<Hcpprofile> Hcpprofiles { get; set; }
        public virtual ICollection<Hcpslot> Hcpslots { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
