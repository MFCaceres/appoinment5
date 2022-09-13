using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Member
    {
        public Member()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int MemberId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string? Gender { get; set; }
        public DateTime Dob { get; set; }
        public string? Relationship { get; set; }
        public int UserId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
