using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.ViewComponents
{
	public class CustomersViewComponent:ViewComponent
	{
        public CustomersViewComponent()
        {
            
        }
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
