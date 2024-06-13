using Business.Services;
using DTO.DTOS.CustomerDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation.ValidationRules.CustomerValidator
{
	public class AddCustomerValidator:AbstractValidator<AddCustomerDTO>
	{
		private readonly ICustomerService _customerService;
        public AddCustomerValidator(AddCustomerDTO dto,ICustomerService customerService,int filialId)

        {
			_customerService = customerService;
			RuleFor(x => x.Female).NotEmpty().WithMessage("Müştərinin cinsini seçmədiniz!");
			RuleFor(x => x.FullName).NotEmpty().WithMessage("Ad və soyad qeyd edin!");
			RuleFor(x => x.PhoneNumber)
		 .Must(phoneNumer=>!_customerService.IsRegistered(dto.PhoneNumber,filialId))
		   .WithMessage("Bu telefon nömrəsi artıq sistemdə qeydiyyatdan keçib");




		}

    }
}
