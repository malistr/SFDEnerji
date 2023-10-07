using Microsoft.AspNetCore.Mvc;

namespace SFDEnerji.Web.Areas.Admin.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
