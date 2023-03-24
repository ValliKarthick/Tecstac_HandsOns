using System.Web.Mvc;
using Tecstac_HandsOns.Models;

namespace Tecstac_HandsOns.Controllers
{
    public class CourseController : Controller
    {
        public ActionResult Course()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Course(Course course)
        {
            return View(course);
        }
    }
}