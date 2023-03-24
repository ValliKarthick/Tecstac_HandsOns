using System;
using System.Linq;
using System.Web.Mvc;
using Tecstac_HandsOns.Models;

namespace Tecstac_HandsOns.Controllers
{
    public class StudentController : Controller
    {
        private CollegeContext db = new CollegeContext();
        public ActionResult Placement()
        {
            return View(db.Placements.ToList<Placement>());
        }
        public ActionResult Index()
        {
            Student student = new Student();
            student.StudentName = "Johana";
            student.Department = "Art";
            student.PhoneNumber = 9876565434;
            student.EnrolledDate = Convert.ToDateTime("2018/06/25");
            return RedirectToAction("AddDetail", student);
        }
        public ActionResult AddDetail(Student student)
        {
            CollegeContext context = new CollegeContext();
            context.Students.Add(student);
            context.SaveChanges();
            return View("ViewDetails", student);
        }
    }
}