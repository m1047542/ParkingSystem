using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingSystem.Models
{
    public class ParkingRequestViewModel
    {
        public IEnumerable<City> Cities { get; set; }
        public IEnumerable<Provider> Providers { get; set; }
    }

    public class City
    {
        public string CityName { get; set; }
        public int CityId { get; set; }
    }

    public class Provider
    {
        public string ProviderName { get; set; }
        public int ProviderId { get; set; }
    }
}