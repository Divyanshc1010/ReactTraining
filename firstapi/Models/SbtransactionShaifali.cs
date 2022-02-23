using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class SbtransactionShaifali
    {
        public int TransactionId { get; set; }
        public int AccountNumber { get; set; }
        public int Amount { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
