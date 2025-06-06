using Microsoft.AspNetCore.Mvc;

namespace Law_Firm.Controllers
{
    public class AudienceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
