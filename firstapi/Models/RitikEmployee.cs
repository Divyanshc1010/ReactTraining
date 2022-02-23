using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class RitikEmployee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? Doj { get; set; }
        public string City { get; set; }
    }
}
