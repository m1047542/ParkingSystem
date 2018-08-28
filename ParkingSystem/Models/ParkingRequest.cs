using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingSystem.Models
{
    public class ParkingRequest
    {
        public int ParkingRequestId { get; set; }
        public string ParkingRequestName { get; set; }
        public int ParkingCityId { get; set; }
        public string ParkingCityName { get; set; }
        public int ParkingProviderId { get; set; }
        public string ParkingProviderName { get; set; }
        public DateTime CheckinDateTime { get; set; }
        public DateTime CheckoutDateTime { get; set; }
    }
}