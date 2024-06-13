using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.Controllers
{
    [Area("TestSalon")]
    public class DashboardController : Controller
    {

        public IActionResult LazerAppointment()
        {
            return View();
        }
    }
}
