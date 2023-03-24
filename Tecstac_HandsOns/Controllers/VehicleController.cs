using System.Web.Mvc;
using Tecstac_HandsOns.Models;

namespace Tecstac_HandsOns.Controllers
{
    public class VehicleController : Controller
    {
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Registration Model)
        {
            ViewBag.CustomerName = Model.CustomerName;
            ViewBag.VehicleNo = Model.VehicleNo;
            ViewBag.PhoneNumber = Model.PhoneNumber;
            ViewBag.City = Model.City;
            return View("Confirm");
        } 
    }
}