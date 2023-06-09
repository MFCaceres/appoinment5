﻿using System;
using System.Collections.Generic;

namespace HealthCon.WebAPI.Models
{
    public partial class Subscriptionpayment
    {
        public long Subscriptionpaymentid { get; set; }
        public string? TransactionSubject { get; set; }
        public string? PaymentDate { get; set; }
        public string? TxnType { get; set; }
        public string? LastName { get; set; }
        public string? ResidenceCountry { get; set; }
        public string? ItemName { get; set; }
        public decimal? PaymentGross { get; set; }
        public string? McCurrency { get; set; }
        public string? Business { get; set; }
        public string? PaymentType { get; set; }
        public string? ProtectionEligibility { get; set; }
        public string? VerifySign { get; set; }
        public string? PayerStatus { get; set; }
        public string? TestIpn { get; set; }
        public string? Tax { get; set; }
        public string? PayerEmail { get; set; }
        public string? TxnId { get; set; }
        public int? Quantity { get; set; }
        public string? ReceiverEmail { get; set; }
        public string? FirstName { get; set; }
        public string? PayerId { get; set; }
        public string? ReceiverId { get; set; }
        public string? ItemNumber { get; set; }
        public string? PaymentStatus { get; set; }
        public decimal? PaymentFee { get; set; }
        public decimal? McFee { get; set; }
        public decimal? McGross { get; set; }
        public string? Custom { get; set; }
        public string? Charset { get; set; }
        public string? NotifyVersion { get; set; }
        public string? IpnTrackId { get; set; }
        public string? PendingReason { get; set; }
        public string? Errordetails { get; set; }
        public int? UserId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public byte? SortOrder { get; set; }
        public string? PreapprovalKey { get; set; }
    }
}
