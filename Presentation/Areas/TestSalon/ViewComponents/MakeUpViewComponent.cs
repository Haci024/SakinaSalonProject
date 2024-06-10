using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.ViewComponents
{
	public class MakeUpViewComponent:ViewComponent
	{
        public MakeUpViewComponent()
        {
            
        }
        public IViewComponentResult Invoke()
		{
			
			return View();
		}
	}
}
