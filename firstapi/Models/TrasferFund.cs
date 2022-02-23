using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class TrasferFund
    {
        public int Id { get; set; }
        public long FromAccount { get; set; }
        public long ToAccount { get; set; }
        public decimal Amount { get; set; }
    }
}
