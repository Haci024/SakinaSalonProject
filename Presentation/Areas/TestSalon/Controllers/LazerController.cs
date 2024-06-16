using Business.Services;
using Data.Context;
using DTO.DTOS.LazerAppointmentDTO;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Presentation.Areas.TestSalon.Controllers
{
	[Area("TestSalon")]
	public class LazerController : Controller
	{
		private readonly ILazerAppointmentService _lazerService;
		private readonly ICustomerService _customers;
        public LazerController(ILazerAppointmentService lazerAppointmentService,ICustomerService customers)
        {
            _lazerService = lazerAppointmentService;
			_customers = customers;
        }
        [HttpGet]
		public async Task<IActionResult> ReservationList()
		{
			
			
			IQueryable<LazerAppointment> reservations = await _lazerService.GetAllReservations(1);
			
			
			
			return View(reservations);
		}
		[HttpGet]
		public IActionResult AddAppointment()
		{
			AddReservationDTO dto=new AddReservationDTO();
			
			return View(dto);
		}
		[HttpPost]
		public IActionResult AddAppointment(AddReservationDTO dto)
		{


			return RedirectToAction();
		}

	}
}
