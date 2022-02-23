using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class AviBookingDetail
    {
        public int BookingId { get; set; }
        public int FlightId { get; set; }
        public int? RoutId { get; set; }
        public DateTime Doj { get; set; }
        public int NumberOfPass { get; set; }
        public double TotalValue { get; set; }
    }
}
