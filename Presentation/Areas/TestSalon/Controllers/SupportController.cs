using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.Controllers
{
	[Area("TestSalon")]
	public class SupportController : Controller
	{
		[HttpGet]
		public IActionResult GuideBook()
		{

			return View();
		}
	}
}
