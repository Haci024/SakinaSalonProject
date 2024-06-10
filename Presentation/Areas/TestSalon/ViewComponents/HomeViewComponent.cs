using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.ViewComponents
{
	public class HomeViewComponent:ViewComponent
	{
        public HomeViewComponent()
        {
            
        }
        public IViewComponentResult Invoke()
        {

            return View();  
        }
    }
}
