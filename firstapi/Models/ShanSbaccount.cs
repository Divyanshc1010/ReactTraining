using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class ShanSbaccount
    {
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int AccountNumber { get; set; }
        public decimal? CurrentBalance { get; set; }
    }
}
