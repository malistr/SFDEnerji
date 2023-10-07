using Microsoft.AspNetCore.Mvc;

namespace SFDEnerji.Web.Areas.Admin.Controllers
{
    
    public class DashboardController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
