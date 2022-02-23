using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class AjaySbtransaction1
    {
        public int TransactionId { get; set; }
        public string TransactionDate { get; set; }
        public int AccountNumber { get; set; }
        public double? Amount { get; set; }
        public string TransactionType { get; set; }
    }
}
