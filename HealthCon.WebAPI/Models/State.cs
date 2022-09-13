using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class State
    {
        public State()
        {
            Addresses = new HashSet<Address>();
            Cities = new HashSet<City>();
            ClinicProfiles = new HashSet<ClinicProfile>();
            Hcpprofiles = new HashSet<Hcpprofile>();
        }

        public int StateId { get; set; }
        public string StateName { get; set; } = null!;
        public string StateCode { get; set; } = null!;
        public int CountryId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<ClinicProfile> ClinicProfiles { get; set; }
        public virtual ICollection<Hcpprofile> Hcpprofiles { get; set; }
    }
}
