using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class BookingDetail
    {
        public int Bookingid { get; set; }
        public int? Flightid { get; set; }
        public int? Routeid { get; set; }
        public DateTime? Doj { get; set; }
        public int? Numberofpassengers { get; set; }
        public double? Totalvalue { get; set; }
        public int? Customerid { get; set; }
    }
}
