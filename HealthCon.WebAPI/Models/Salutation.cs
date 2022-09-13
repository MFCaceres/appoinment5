using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Salutation
    {
        public int SalutationId { get; set; }
        public string SalutationName { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }
    }
}
