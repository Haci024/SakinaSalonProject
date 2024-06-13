using AutoMapper;
using Business.Services;
using Data.Context;
using DTO.DTOS.CustomerDTO;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.TestSalon.ViewComponents
{
	public class DailyWorksViewComponent:ViewComponent
	{
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public DailyWorksViewComponent(ICustomerService  customerService,IMapper mapper)
        {
            _customerService=customerService;
            _mapper=mapper;
        }
        public  IViewComponentResult Invoke()
        {
            int Count = _customerService.BirthDateCount(1);
			ViewBag.BirthDateCount = Count; 
			return View();
        }
    }
}
