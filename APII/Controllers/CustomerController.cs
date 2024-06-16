using AutoMapper;
using Business.Services;
using DTO.DTOS.CustomerDTO;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
       
        public CustomerController(ICustomerService customer,IMapper mapper)
        {
            _customerService = customer;
            _mapper = mapper;
        }
        [HttpGet("ActiveCustomerList")]
        public async Task<IActionResult> ActiveCustomerList(int filialId) {

            return Ok(_mapper.Map<IEnumerable<CustomerListDTO>>(await _customerService.ActiveCustomerList(filialId)));
        }
        [HttpGet("FemaleList")]
        public async Task<IActionResult> FemaleList(int filialId)
        {
             
           
            return Ok(_mapper.Map<IEnumerable<CustomerListDTO>>(await _customerService.FemaleList(filialId)));
        }
        [HttpGet("MaleList")]
        public async Task<IActionResult> MaleList(int filialId)
        {

            return Ok(_mapper.Map<IEnumerable<CustomerListDTO>>(await _customerService.MaleList(filialId)));
        }
        [HttpGet("BirthDateList")]
        public async Task<IActionResult> BirthDateList(int filialId)
        {

            return Ok(_mapper.Map<IEnumerable<CustomerListDTO>>(await _customerService.BirthDateList(filialId)));
        }
        [HttpGet("DeactiveCustomerList")]
        public async Task<IActionResult> DeactiveCustomerList(int filialId)
        {

            return Ok(_mapper.Map<IEnumerable<CustomerListDTO>>(await _customerService.InActiveCustomerList(filialId)));
        }
        [HttpPost("AddCustomer")]
        public async Task<IActionResult> AddCustomer(AddCustomerDTO dto)
        {
            Customers entity = new();
            _mapper.Map(dto, entity);
             _customerService.Create(entity);
           
            return Ok(entity);
        }
        [HttpPut("UpdateCustomer")]
        public async Task<IActionResult> UpdateCustomet(UpdateCustomerDTO dto)
        {
            Customers entity =await _customerService.GetById(dto.Id);
            _mapper.Map(dto, entity);
            _customerService.Update(entity);
           
            return Ok(entity);
        }
        [HttpDelete("DeleteCustomer")]
        public async Task<IActionResult> DeleteCustomer(int Id)
        {
            var entity = await _customerService.GetById(Id);
            _customerService.Delete(entity);
            return Ok(entity +" Uğurla silindi!");
        }

        [HttpPut("UpdateStatus")]
        public async Task<IActionResult> UpdateStatus(int Id)
        {
            var entity = await _customerService.GetById(Id);
            
            return Ok(entity + " Uğurla silindi!");
        }
        [HttpGet("BirthDateCount")]
       public IActionResult BirthDateCount(int filialId)
        {
           
            
            return Ok(_customerService.BirthDateCount(filialId));   
        }
    }
}
