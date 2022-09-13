using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class City
    {
        public City()
        {
            Addresses = new HashSet<Address>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; } = null!;
        public string CityCode { get; set; } = null!;
        public int StateId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual State State { get; set; } = null!;
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
