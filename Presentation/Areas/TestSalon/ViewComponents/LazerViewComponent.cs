using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Presentation.Areas.TestSalon.ViewComponents
{
	public class LazerViewComponent:ViewComponent
	{
	
		public  IViewComponentResult Invoke()
		{

			return View();
		}
	}
}
