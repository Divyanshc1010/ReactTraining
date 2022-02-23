using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class BhramarSbtransaction
    {
        public string TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int AccountNumber { get; set; }
        public double Amount { get; set; }
        public string TransactionType { get; set; }
    }
}
