using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class AppointmentChat
    {
        public int AppointmentchatId { get; set; }
        public string? ChatText { get; set; }
        public int AppointmentId { get; set; }
        public int MessageFrom { get; set; }
        public int MessageTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual Appointment Appointment { get; set; } = null!;
    }
}
