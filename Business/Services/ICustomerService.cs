using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
	public interface ICustomerService:IGenericService<Customers>
	{
		public Task<IEnumerable<Customers>> CustomerList(int filialId);
		public Task<IEnumerable<Customers>> ActiveCustomerList(int filialId);
		public Task<IEnumerable<Customers>> FemaleList(int filialId);
		public Task<IEnumerable<Customers>> MaleList(int filialId);
		public Task<IEnumerable<Customers>> InActiveCustomerList(int filialId);
		public Task<Customers> SelectedCustomer(int CustomerId, int filialId);
		public Task<IEnumerable<Customers>> BirthDateList(int filialId);
		public int BirthDateCount(int filialId);
		public bool IsRegistered(string PhoneNumber, int filialId);
	}
}
