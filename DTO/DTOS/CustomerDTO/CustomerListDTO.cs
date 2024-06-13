using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOS.CustomerDTO
{
	public class CustomerListDTO
	{

		public int Id { get; set; }

		public DateTime? BirthDate { get; set; }

		public string FullName { get; set; }

		public string? PhoneNumber { get; set; }

		public bool Female { get; set; }

		public bool Status { get; set; }
	}
}
