using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public long TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public long AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }
    }
}
