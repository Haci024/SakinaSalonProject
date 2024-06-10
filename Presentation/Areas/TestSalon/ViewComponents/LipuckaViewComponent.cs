using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.ViewComponents
{
	public class LipuckaViewComponent:ViewComponent
	{

        public LipuckaViewComponent()
        {
            
        }

        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
