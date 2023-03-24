using System.Web.Mvc;

namespace Tecstac_HandsOns.Controllers
{
    public class HomeController : Controller
    {
        string business = "Flipkart";
        string type = "E-commerce";
        int founded = 2007;
        string website = "www.flipkart.com";

        [Route("Flipkart/info")]
        public ActionResult About()
        {
            ViewBag.business = business;
            ViewBag.type = type;
            ViewBag.founded = founded;
            ViewBag.website = website;
            return View();
        }
    }
}