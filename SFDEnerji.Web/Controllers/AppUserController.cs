using Microsoft.AspNetCore.Mvc;

namespace SFDEnerji.Web.Controllers
{
    public class AppUserController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
