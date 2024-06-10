using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.ViewComponents
{
	public class ShopingViewComponent:ViewComponent
	{
        public ShopingViewComponent()
        {
            
        }
		public IViewComponentResult Invoke()
		{

			return View();
		}
	}
}
