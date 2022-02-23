using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class ManishaSbtransaction
    {
        public int TransId { get; set; }
        public int? Accno { get; set; }
        public decimal? Amt { get; set; }
        public string TransType { get; set; }
        public DateTime? TransDate { get; set; }
    }
}
