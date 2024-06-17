using AutoMapper;
using Business.Services;
using DTO.DTOS.LazerAppointmentDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LazerController : ControllerBase
    {
        private readonly ILazerAppointmentService _appointmentService;
        private readonly IMapper _mapper;
        public LazerController(ILazerAppointmentService categoryService,IMapper mapper)
        {
            _appointmentService = categoryService;
            _mapper = mapper;
        }

        [HttpGet("AllReservations")]
        public async Task<IActionResult> GetReservationList(int filialId) {

           
            return Ok(_mapper.Map<IEnumerable<LazerReservationDTO>>(await _appointmentService.GetAllReservations(filialId)));
        }

       
    }
}
