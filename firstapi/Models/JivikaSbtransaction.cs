using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class JivikaSbtransaction
    {
        public int Id { get; set; }
        public DateTime? Dot { get; set; }
        public int? AccountNo { get; set; }
        public int? Balance { get; set; }
        public string Type { get; set; }
    }
}
