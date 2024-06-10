using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.ViewComponents
{
	
	public class CistkaViewComponent:ViewComponent
	{
        public CistkaViewComponent()
        {
            
        }
        public  IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
