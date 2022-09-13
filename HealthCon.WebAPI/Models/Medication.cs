using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Medication
    {
        public int MedicationId { get; set; }
        public string MedicationName { get; set; } = null!;
        public float MedicationDosage { get; set; }
        public string? PescribeDescription { get; set; }
        public DateTime? PrescribeStartDate { get; set; }
        public DateTime? PrescribeEndDate { get; set; }
        public string? PrescribeDoctor { get; set; }
        public int? MemberId { get; set; }
        public int UserId { get; set; }
        public int Unit { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual Uom UnitNavigation { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
