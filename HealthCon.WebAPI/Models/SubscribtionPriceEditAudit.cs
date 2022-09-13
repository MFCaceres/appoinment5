using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class SubscribtionPriceEditAudit
    {
        public string SubscribtionPriceEditAuditId { get; set; } = null!;
        public string? Description { get; set; }
        public int SubscribtionPriceId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }
    }
}
