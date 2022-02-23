using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class JivikaSbaccount
    {
        public string Id { get; set; }
        public int? AccountNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int? CurrentBalance { get; set; }
    }
}
