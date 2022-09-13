using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Uom
    {
        public Uom()
        {
            Medications = new HashSet<Medication>();
        }

        public int Uomid { get; set; }
        public string Uomname { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual ICollection<Medication> Medications { get; set; }
    }
}
