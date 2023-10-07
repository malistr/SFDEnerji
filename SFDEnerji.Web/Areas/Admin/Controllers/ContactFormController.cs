using Microsoft.AspNetCore.Mvc;

namespace SFDEnerji.Web.Areas.Admin.Controllers
{
    public class ContactFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
