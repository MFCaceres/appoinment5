using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class AppointmentNote
    {
        public int AppointmentNoteId { get; set; }
        public string? Note { get; set; }
        public int AppointmentId { get; set; }
        public int NoteFrom { get; set; }
        public int NotesTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual Appointment Appointment { get; set; } = null!;
    }
}
