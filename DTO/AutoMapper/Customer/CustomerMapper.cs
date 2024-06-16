using AutoMapper;
using DTO.DTOS.CustomerDTO;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AutoMapper.CustomerMapper
{
	public class CustomerMapper:Profile
	{
        public CustomerMapper()
        {
			CreateMap<Customers, CustomerListDTO>();
			CreateMap<CustomerListDTO, Customers>();
			CreateMap<Customers, UpdateCustomerDTO>();
			CreateMap<UpdateCustomerDTO, Customers>().ForMember(dest => dest.BirthDate,
               opt => opt.MapFrom(src => src.BirthDate.HasValue
                   ? DateTime.SpecifyKind(src.BirthDate.Value, DateTimeKind.Utc)
                   : (DateTime?)null));

            CreateMap<AddCustomerDTO, Customers>()
	.ForMember(dest => dest.BirthDate,
			   opt => opt.MapFrom(src => src.BirthDate.HasValue
				   ? DateTime.SpecifyKind(src.BirthDate.Value, DateTimeKind.Utc)
				   : (DateTime?)null));

		}
	}
}
