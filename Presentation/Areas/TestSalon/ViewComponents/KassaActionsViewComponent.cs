using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.ViewComponents
{
	public class KassaActionsViewComponent:ViewComponent
	{
        public KassaActionsViewComponent()
        {
            
        }
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
