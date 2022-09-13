using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class SubscribtionPrice
    {
        public int SubscribtionPriceId { get; set; }
        public string? PricingName { get; set; }
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }
    }
}
