using Microsoft.AspNetCore.Mvc;

namespace Law_Firm.Controllers
{
    public class ProcessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
