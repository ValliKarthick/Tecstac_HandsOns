using System.Web.Mvc;
using Tecstac_HandsOns.Models;

namespace Tecstac_HandsOns.Controllers
{
    public class ProjectController : Controller
    {
        public ActionResult ProjectDetail()
        {
            return View("AddProjectDetails");
        }
        
        [HttpPost]
        public ActionResult ProjectDetail(Project project)
        {
            project.ProjectId = 1;
            ProjectContext pc = new ProjectContext();
            pc.Projects.Add(project);
            pc.SaveChanges();
            return View("ViewProjectDetails", project);
        }
    }
}