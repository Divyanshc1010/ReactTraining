using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class HarshSbtransaction
    {
        public int TransactionId { get; set; }
        public int AccountNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public double Amount { get; set; }
    }
}
