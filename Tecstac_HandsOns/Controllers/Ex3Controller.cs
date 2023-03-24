using System.Collections.Generic;
using System.Web.Mvc;
using Tecstac_HandsOns.Models;

namespace Tecstac_HandsOns.Controllers
{
    public class Ex3Controller : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("CourseDescription");
        }
        public ActionResult IndexChoice(int id)
        {
            if (id == 1)
            {
                return RedirectToAction("CourseDescription");
            }
            else if (id == 2)
            {
                return RedirectToAction("CourseList");
            }
            else return HttpNotFound();
        }
        public ActionResult CourseDescription(Course course)
        {
            course.CourseId = "C101";
            course.CourseName = "Java";
            course.Duration = 40;
            course.Level = "Beginner";
            return View(course);
        }
        public ActionResult CourseList(Department department)
        {
            department.CourseList = new List<string>();
            department.CourseList.Add("Java");
            department.CourseList.Add("DotNet");
            department.CourseList.Add("Python");
            department.CourseList.Add("Ruby");
            return View(department);
        }

        List<ShoppingCart> l1 = new List<ShoppingCart>() {new ShoppingCart("CA1","Shoe",3000,"Sport"),
                                new ShoppingCart("CA2", "Shirt", 1500, "Men's Wear"),
                                new ShoppingCart("CA3","Watch",4000,"Accessories"),
                                new ShoppingCart("CA4","Samsung",15000,"Mobiles")};
        public ActionResult Cart(int id)
        {
            if (id <= 4)
            {
                return View(l1[id - 1]);
            }
            else
            {
                return HttpNotFound();
            }
        }
        [HttpPost]
        public ActionResult Cart(ShoppingCart shoppingCart)
        {
            return View(shoppingCart);
        }
    }
}