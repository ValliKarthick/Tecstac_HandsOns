using System.Collections.Generic;
using System.Web.Mvc;

namespace Tecstac_HandsOns.Controllers
{
    public class Ex1Controller : Controller
    {
        List<string> breakingNews = new List<string>()      //DO NOT change this declaration and values
            {
            "PM visit brings business","10% slash in GST","Top Player announced retirement","India wins series"
            };
        public ActionResult NewsByChoice(int id)
        {
            if (id > 0 && id <= 4)
            {
                return Content(breakingNews[id - 1]);
            }
            else
            {
                return HttpNotFound();
            }
        }
        public ActionResult AllNews()
        {
            return Content(string.Join("<br>", breakingNews));
        }
    }
}