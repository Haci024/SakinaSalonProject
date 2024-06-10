using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.ViewComponents
{
	public class CosmetologyViewComponent:ViewComponent
	{
		
		public IViewComponentResult Invoke()
		{

			return View();
		}
	}
}
