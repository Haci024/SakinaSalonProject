using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.ViewComponents
{
	public class UserInfoViewComponent:ViewComponent
	{
       
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
