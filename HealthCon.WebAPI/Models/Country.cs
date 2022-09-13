using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Country
    {
        public Country()
        {
            Addresses = new HashSet<Address>();
            Hcpeducations = new HashSet<Hcpeducation>();
            States = new HashSet<State>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; } = null!;
        public string CountryCode { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Hcpeducation> Hcpeducations { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}
