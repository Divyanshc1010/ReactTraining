using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class SbTransactionYash
    {
        public string TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }
    }
}
