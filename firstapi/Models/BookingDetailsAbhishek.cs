using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class BookingDetailsAbhishek
    {
        public int BookingId { get; set; }
        public int FlightId { get; set; }
        public int RouteId { get; set; }
        public DateTime Doj { get; set; }
        public int Noofpassanger { get; set; }
        public decimal Totalvalue { get; set; }
        public int CustomerId { get; set; }
    }
}
