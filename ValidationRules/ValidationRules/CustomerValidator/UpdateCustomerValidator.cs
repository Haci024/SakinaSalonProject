using DTO.DTOS.CustomerDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation.ValidationRules.CustomerValidator
{
    public class UpdateCustomerValidator:AbstractValidator<UpdateCustomerDTO>
    {
        public UpdateCustomerValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("Ad və soyad boş ola bilməz...");
            
        }
    }
}
