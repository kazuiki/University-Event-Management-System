using Microsoft.AspNetCore.Mvc;

namespace University_Event_Management_System.Areas.User.Controllers
{
    [Area("User")]
    public class CreateAccountController : Controller
    {
        public IActionResult CreateAccount()
        {
            return View();
        }
    }
}
