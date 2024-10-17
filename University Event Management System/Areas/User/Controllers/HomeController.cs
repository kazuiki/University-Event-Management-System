using Microsoft.AspNetCore.Mvc;

namespace University_Event_Management_System.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
       
        public IActionResult Home()
        {
            return View();
        }
    }
}
