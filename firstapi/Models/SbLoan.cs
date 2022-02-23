using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class SbLoan
    {
        public int Id { get; set; }
        public long ToAccount { get; set; }
        public decimal Amount { get; set; }
        public int DurationInDays { get; set; }
        public double Intrest { get; set; }
    }
}
