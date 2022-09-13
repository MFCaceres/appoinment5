using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Docsubscription
    {
        public int Docsubscriptionid { get; set; }
        public int? MaxNumberOfPayments { get; set; }
        public DateTime? StartingDate { get; set; }
        public string? PinType { get; set; }
        public decimal? MaxAmountPerPayment { get; set; }
        public string? CurrencyCode { get; set; }
        public string? SenderEmail { get; set; }
        public string? VerifySign { get; set; }
        public string? TestIpn { get; set; }
        public int? DateOfMonth { get; set; }
        public int? CurrentNumberOfPayments { get; set; }
        public string? PreapprovalKey { get; set; }
        public DateTime? EndingDate { get; set; }
        public bool? IsApproved { get; set; }
        public string? TransactionType { get; set; }
        public string? DayOfWeek { get; set; }
        public string? Status { get; set; }
        public decimal? CurrentTotalAmountOfAllPayments { get; set; }
        public int? CurrentPeriodAttempts { get; set; }
        public string? Charset { get; set; }
        public string? PaymentPeriod { get; set; }
        public string? NotifyVersion { get; set; }
        public decimal? MaxTotalAmountOfAllPayments { get; set; }
        public string? Errordetails { get; set; }
        public int? UserId { get; set; }
        public DateTime? Createddate { get; set; }
        public string? Createdby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public string? Modifiedby { get; set; }
        public bool? Isdeleted { get; set; }
    }
}
