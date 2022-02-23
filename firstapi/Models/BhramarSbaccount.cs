using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class BhramarSbaccount
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string CurrentAddress { get; set; }
        public double CurrentBalance { get; set; }
    }
}
