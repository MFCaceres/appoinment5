using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class BoardCertification
    {
        public BoardCertification()
        {
            HcpboardCertifications = new HashSet<HcpboardCertification>();
        }

        public int BoardCertificationId { get; set; }
        public string CertificationTitle { get; set; } = null!;
        public string? CertificationDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual ICollection<HcpboardCertification> HcpboardCertifications { get; set; }
    }
}
