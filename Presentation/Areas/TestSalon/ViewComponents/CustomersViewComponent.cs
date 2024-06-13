using Business.Services;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.ViewComponents
{
	public class CustomersViewComponent:ViewComponent
	{
        
        public CustomersViewComponent(ICustomerService customer)
        {
            
        }
        public IViewComponentResult Invoke()
        {
        
            return View();
        }
    }
}
