using System.Web.Mvc;

namespace Tecstac_HandsOns.Controllers
{
    public class ChTrustController : Controller
    {
        public ActionResult ChTrust()
        {
            return View();
        }
        public ActionResult _HeaderNavBar()
        {
            return PartialView("_HeaderNavBar");
        }
        public ActionResult _FooterNavBar()
        {
            return PartialView("_FooterNavBar");
        }
    }
}