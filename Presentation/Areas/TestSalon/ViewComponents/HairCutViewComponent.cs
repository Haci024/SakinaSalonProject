using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.ViewComponents
{
	public class HairCutViewComponent:ViewComponent
	{
        public HairCutViewComponent()
        {
            
        }
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
