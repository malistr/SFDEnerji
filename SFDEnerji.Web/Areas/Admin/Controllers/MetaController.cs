using Microsoft.AspNetCore.Mvc;

namespace SFDEnerji.Web.Areas.Admin.Controllers
{
    public class MetaController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
