using System.Web.Mvc;

namespace Tecstac_HandsOns.Controllers
{
    public class Ex2Controller : Controller
    {
        public ActionResult Course(int id)
        {
            if (id == 1)
                return RedirectToAction("JavaCourse");
            else if (id == 2)
                return RedirectToAction("DotNetCourse");
            else
                return HttpNotFound();
        }
        public ActionResult JavaCourse()
        {
            return View("JavaCourse");
        }
        public ActionResult DotNetCourse()
        {
            return View("DotNetCourse");
        }
    }
}