using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public long AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public decimal CurrentBalance { get; set; }
    }
}
