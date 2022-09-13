using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Report
    {
        public int ReportId { get; set; }
        public string? ReportName { get; set; }
        public DateTime? ReportDate { get; set; }
        public string ReportUrl { get; set; } = null!;
        public int? MemberId { get; set; }
        public int UserId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
