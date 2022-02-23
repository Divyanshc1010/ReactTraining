using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class DivyanshSbaccount
    {
        public int AccountNumber { get; set; }
        public string Customername { get; set; }
        public string Customeraddress { get; set; }
        public double? Currentbalance { get; set; }
    }
}
