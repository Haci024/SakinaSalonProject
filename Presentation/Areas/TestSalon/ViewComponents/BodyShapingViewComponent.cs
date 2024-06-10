using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.ViewComponents
{
	public class BodyShapingViewComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			return View();
		}
	}
}
