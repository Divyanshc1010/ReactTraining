using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class Shivamsbtransaction
    {
        public int Transactionid { get; set; }
        public DateTime Transationdate { get; set; }
        public int Accountnumber { get; set; }
        public int Amount { get; set; }
        public string Transactiontype { get; set; }
    }
}
