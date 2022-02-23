using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class DarshanSbtransaction
    {
        public string TransactionId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? AccountNumber { get; set; }
        public decimal? Amount { get; set; }
        public string TransactionType { get; set; }
    }
}
