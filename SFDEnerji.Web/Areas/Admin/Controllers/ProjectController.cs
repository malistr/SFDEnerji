using Microsoft.AspNetCore.Mvc;

namespace SFDEnerji.Web.Areas.Admin.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
