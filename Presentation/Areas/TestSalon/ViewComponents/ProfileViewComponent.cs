using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.ViewComponents
{

	public class ProfileViewComponent:ViewComponent
	{
        public ProfileViewComponent()
        {
            
        }
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
