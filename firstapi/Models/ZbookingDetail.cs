using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class ZbookingDetail
    {
        public int BookingId { get; set; }
        public int? FlightId { get; set; }
        public int? RouteId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? DateOfJourney { get; set; }
        public int? NumberOfPassengers { get; set; }
        public decimal? TotalCost { get; set; }
    }
}
