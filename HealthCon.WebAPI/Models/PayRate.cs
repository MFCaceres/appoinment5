using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class PayRate
    {
        public int PayrateId { get; set; }
        public float DurationInMinute { get; set; }
        public double ConsultationFee { get; set; }
        public double CancellationFee { get; set; }
        public int UserId { get; set; }
        public int CurrencyId { get; set; }
        public int ClinicProfileId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual ClinicProfile ClinicProfile { get; set; } = null!;
        public virtual Currency Currency { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
