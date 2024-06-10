using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.Controllers
{
	[Area("TestSalon")]
	public class LazerController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
