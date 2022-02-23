using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class ShanSbtransaction
    {
        public int TransactionId { get; set; }
        public int AccountNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public decimal? Amount { get; set; }
    }
}
