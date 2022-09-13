using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Speciality
    {
        public Speciality()
        {
            ClinicSpecialities = new HashSet<ClinicSpeciality>();
            Hcpspecializations = new HashSet<Hcpspecialization>();
        }

        public int SpecialityId { get; set; }
        public string SpecialityName { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual ICollection<ClinicSpeciality> ClinicSpecialities { get; set; }
        public virtual ICollection<Hcpspecialization> Hcpspecializations { get; set; }
    }
}
