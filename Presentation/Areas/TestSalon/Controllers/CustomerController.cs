using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.Controllers
{
	public class CustomerController : Controller
	{
		[Area("TestSalon")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
