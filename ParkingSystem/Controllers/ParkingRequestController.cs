using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParkingSystem.Controllers
{
    //Parking request controller
    public class ParkingRequestController : Controller
    {
        // GET: ParkingRequest
        public ActionResult Index()
        {
            return View();
        }
    }
}