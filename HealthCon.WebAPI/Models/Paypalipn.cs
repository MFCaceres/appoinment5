using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Paypalipn
    {
        public long Paypalipnid { get; set; }
        public string? Paypalresponse { get; set; }
        public string? Createdby { get; set; }
        public DateTime? Createddate { get; set; }
        public string? Modifiedby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public string? Guid { get; set; }
    }
}
