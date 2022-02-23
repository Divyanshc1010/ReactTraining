using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class ZflightDetail
    {
        public int FlightId { get; set; }
        public string FlightName { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime? DepartureTime { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public int? TotalCapacity { get; set; }
        public int? CostPerSeat { get; set; }
        public string Logo { get; set; }
    }
}
