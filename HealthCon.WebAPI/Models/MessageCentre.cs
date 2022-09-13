using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class MessageCentre
    {
        public int MessageCentreId { get; set; }
        public string? SenderMessageStatus { get; set; }
        public string? ReceiverMessageStatus { get; set; }
        public int MessageFrom { get; set; }
        public int MessageTo { get; set; }
        public string MessageSubject { get; set; } = null!;
        public string? MessageBody { get; set; }
        public DateTime? MessageDate { get; set; }
        public string? AttachmentUrl { get; set; }
        public string? MessageFromEmail { get; set; }
        public string? MessageToEmail { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }
    }
}
