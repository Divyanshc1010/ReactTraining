using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class BookingDetailsAjay
    {
        public int BookingId { get; set; }
        public int? FlightId { get; set; }
        public int? RouteId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? Doj { get; set; }
        public int? NumberOfPassengers { get; set; }
        public int? TotalValue { get; set; }
    }
}
