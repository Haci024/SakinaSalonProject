using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.ViewComponents
{
	public class KassaActionsViewComponent:ViewComponent
	{
        public KassaActionsViewComponent()
        {
            
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}
