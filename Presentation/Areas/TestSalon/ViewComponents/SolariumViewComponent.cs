using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.ViewComponents
{
	public class SolariumViewComponent:ViewComponent
	{
       public IViewComponentResult Invoke()
		{

			return View();
		}
	}
}
