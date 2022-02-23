using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class LekhanaSbtran
    {
        public int TId { get; set; }
        public int Accno { get; set; }
        public int Amt { get; set; }
        public string TType { get; set; }
        public DateTime TDate { get; set; }
    }
}
