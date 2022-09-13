using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Hcpspecialization
    {
        public int HcpspecializationId { get; set; }
        public int Hcpid { get; set; }
        public int SpecialityId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual User Hcp { get; set; } = null!;
        public virtual Speciality Speciality { get; set; } = null!;
    }
}
