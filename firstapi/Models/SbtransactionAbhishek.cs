using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class SbtransactionAbhishek
    {
        public decimal TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal AccountNumber { get; set; }
        public int Amount { get; set; }
        public string TransactionType { get; set; }
    }
}
