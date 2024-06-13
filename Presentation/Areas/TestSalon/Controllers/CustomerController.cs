using AutoMapper;
using Business.Services;
using Data.Services.EntityService;
using DTO.DTOS.CustomerDTO;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System.Collections.Generic;
using Validation.ValidationRules.CustomerValidator;

namespace Presentation.Areas.TestSalon.Controllers
{
	[Area("TestSalon")]
	public class CustomerController : Controller
	{
		private readonly ICustomerService _customerService;
		private readonly ILazerAppointmentService _lazerApp;	
		private readonly IMapper _mapper;
		private readonly ICosmetologyService _cosmetologyService;
		
		
        public CustomerController(ICustomerService customerService,ICosmetologyService cosmetologyService,ILazerAppointmentService lazerAppointmentService,IMapper mapper)
        {
            _customerService = customerService;
			_lazerApp = lazerAppointmentService;
			_mapper = mapper;
			_cosmetologyService = cosmetologyService;
        }
        [HttpGet]
		public async  Task<IActionResult> FemaleList()
		{
			var femaleList= _mapper.Map<IEnumerable<CustomerListDTO>>(await _customerService.FemaleList(1));	
			return View(femaleList);
		}
		[HttpGet]
		public async Task<IActionResult> BirthDateList()
		{

			IEnumerable<CustomerListDTO> bithdateList = _mapper.Map<IEnumerable<CustomerListDTO>>(await _customerService.BirthDateList(1));
			
			return View(bithdateList);	
		}

		[HttpGet]
		public async Task<IActionResult> MaleList()
		{

            IEnumerable<CustomerListDTO> maleList = _mapper.Map<IEnumerable<CustomerListDTO>>(await _customerService.MaleList(1));
			return View(maleList);
		}

		[HttpGet]
		public async Task<IActionResult> AllCustomers()
		{
            IEnumerable<CustomerListDTO> customers = _mapper.Map<IEnumerable<CustomerListDTO>>(await _customerService.ActiveCustomerList(1));
			
			return View(customers);
		}
		[HttpGet]
		public async Task<IActionResult> DeactiveCustomerList()
		{
            IEnumerable<CustomerListDTO> customers = _mapper.Map<IEnumerable<CustomerListDTO>>(await _customerService.InActiveCustomerList(1));
			return View(customers);
		}
		[HttpGet]
		public async Task<IActionResult> AddCustomer()
		{
			AddCustomerDTO dto = new();	
			return View(dto);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AddCustomer(AddCustomerDTO dto)
		{
			var validator = new AddCustomerValidator(dto,_customerService,1);
			
			var validationResult = validator.Validate(dto);
			if (!validationResult.IsValid)
			{
				foreach (var item in validationResult.Errors)
				{
					ModelState.AddModelError("", item.ErrorMessage);
				}
				return View(dto);
			}
			Customers entity = new();
			_mapper.Map(dto, entity);
			entity.FilialId = 1;
			
			
			_customerService.Create(entity);
			return RedirectToAction("AllCustomers");
		}
		[HttpGet]
		public async Task<IActionResult> UpdateCustomer(int Id)
		{
   UpdateCustomerDTO dto=_mapper.Map<UpdateCustomerDTO>(await _customerService.SelectedCustomer(Id,1));
			
			return View(dto);
		}
        [HttpPost]
		[ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateCustomer(UpdateCustomerDTO dto)
        {
			UpdateCustomerValidator validations = new();
			   var validationRules=validations.Validate(dto);
			if (!validationRules.IsValid)
			{
				foreach (var item in validationRules.Errors)
				{
					ModelState.AddModelError("",item.ErrorMessage);
				}
				return View(dto);
			}
			Customers entity =await  _customerService.GetById(dto.Id);
	     	 _mapper.Map(dto, entity);
			_customerService.Update(entity);
			return RedirectToAction("AllCustomers");
        }
    }
}
