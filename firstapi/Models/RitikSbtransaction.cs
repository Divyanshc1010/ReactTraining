using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class RitikSbtransaction
    {
        public string TransactionId { get; set; }
        public string TransactionDate { get; set; }
        public string AccountNumber { get; set; }
        public string Amount { get; set; }
        public string TransactionType { get; set; }
    }
}
