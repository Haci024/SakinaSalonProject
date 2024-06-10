using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.Controllers
{
	[Area("TestSalon")]
	public class CosmetologyController : Controller
	{
		[HttpGet]
		public IActionResult NewCosmetologyAppointment()
		{

			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult NewCosmetologyAppointment(int Id)
		{
			return View();
		}
		[HttpGet]
		public IActionResult ReservationPage()
		{

			return View();
		}
	}
}
