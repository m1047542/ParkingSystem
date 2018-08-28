using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ParkingSystem.Models;

namespace ParkingSystem.Controllers
{    
    public class HomeController : Controller
    {
        static HttpClient httpClient = new HttpClient();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> ParkingRequest()
        {

            IEnumerable<City> lstCity = await GetCityAsync();
            IEnumerable<Provider> lstProvider = new List<Provider>();
            ParkingRequestViewModel parkingRequestViewModel = new ParkingRequestViewModel();
            parkingRequestViewModel.Cities = lstCity;
            parkingRequestViewModel.Providers = lstProvider;
            return View(parkingRequestViewModel);
        }        

        public async Task<IEnumerable<City>> GetCityAsync()
        {
            IEnumerable<City> cities = null;
            HttpResponseMessage response = await httpClient.GetAsync("http://localhost:55823/api/ParkingRequest/Cities");
            if (response.IsSuccessStatusCode)
            {
                cities = await response.Content.ReadAsAsync<IEnumerable<City>>();
            }
            return cities;
        }

        public async Task<IEnumerable<Provider>> GetProviderAsync()
        {
            IEnumerable<Provider> providers = null;
            HttpResponseMessage response = await httpClient.GetAsync("http://localhost:55823/api/ParkingRequest/Providers");
            if (response.IsSuccessStatusCode)
            {
                providers = await response.Content.ReadAsAsync<IEnumerable<Provider>>();
            }
            return providers;
        }

        [HttpGet]
        public async Task<JsonResult> ProvidersByCity(int cityId)
        {
            string requestUri = "http://localhost:55823/api/ParkingRequest/" + cityId + "/Providers";
            IEnumerable<Provider> providers = null;
            HttpResponseMessage response = await httpClient.GetAsync(requestUri);
            if (response.IsSuccessStatusCode)
            {
                providers = await response.Content.ReadAsAsync<IEnumerable<Provider>>();
            }

            return Json(providers, JsonRequestBehavior.AllowGet);
        }
    }
}