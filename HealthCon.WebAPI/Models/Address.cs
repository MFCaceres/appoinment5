using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }
        public string? ContactPersonName { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        public long? PersonalContactNo { get; set; }
        public long? BuisnessContactNo { get; set; }
        public long? FaxNo { get; set; }
        public int UserId { get; set; }
        public int? ClinicProfileId { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public int ZipCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual City City { get; set; } = null!;
        public virtual ClinicProfile? ClinicProfile { get; set; }
        public virtual Country Country { get; set; } = null!;
        public virtual State State { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
