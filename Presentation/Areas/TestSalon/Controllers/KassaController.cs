using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.Controllers
{
	[Area("TestSalon")]
	public class KassaController : Controller
	{
		public IActionResult KassaPage()
		{
			return View();
		}
	}
}
