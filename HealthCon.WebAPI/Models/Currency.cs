using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Currency
    {
        public Currency()
        {
            PayRates = new HashSet<PayRate>();
        }

        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; } = null!;
        public string CurrencyCode { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual ICollection<PayRate> PayRates { get; set; }
    }
}
