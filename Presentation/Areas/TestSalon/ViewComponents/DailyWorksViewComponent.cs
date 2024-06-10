using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.ViewComponents
{
	public class DailyWorksViewComponent:ViewComponent
	{
        public DailyWorksViewComponent()
        {
            
        }
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
