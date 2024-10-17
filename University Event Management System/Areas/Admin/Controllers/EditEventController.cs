using Microsoft.AspNetCore.Mvc;

namespace University_Event_Management_System.Areas.Admin.Controllers
{
    public class EditEventController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
