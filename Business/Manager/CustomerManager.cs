using Business.Services;
using Data.DAL.Customer;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager
{
	public class CustomerManager : ICustomerService
	{
		private readonly ICustomerDAL _dal;
        public CustomerManager(ICustomerDAL dal)
        {
            _dal = dal;
        }

		public async Task<IEnumerable<Customers>> ActiveCustomerList(int filialId)
		{
			return await _dal.ActiveCustomerList(filialId);
		}

		public int BirthDateCount(int filialId)
		{
			return _dal.BirthDateCount(filialId);
		}

		public async Task<IEnumerable<Customers>> BirthDateList(int filialId)
		{
			return await _dal.BirthDateList(filialId);
		}

		public void Create(Customers entity)
		{
		_dal.Create(entity);
		}

		public async Task<IEnumerable<Customers>> CustomerList(int filialId)
		{
			return await _dal.CustomerList(filialId);
		}

		public void Delete(Customers entity)
		{
			_dal.Delete(entity);
		}

		public async Task<IEnumerable<Customers>> FemaleList(int filialId)
		{
			return await _dal.FemaleList(filialId);
		}

		public Task<Customers> GetById(int Id)
		{
			return _dal.GetById(Id);
		}

		public Task<IEnumerable<Customers>> GetList()
		{
			return _dal.GetList();
		}

		public async Task<IEnumerable<Customers>> InActiveCustomerList(int filialId)
		{
			return await _dal.InActiveCustomerList(filialId);
		}

		public bool IsRegistered(string PhoneNumber, int filialId)
		{
			return _dal.IsRegistered(PhoneNumber, filialId);
		}

		public async Task<IEnumerable<Customers>> MaleList(int filialId)
		{
			return await _dal.MaleList(filialId);
		}

		public async Task<Customers> SelectedCustomer(int CustomerId, int filialId)
		{
			return await _dal.SelectedCustomer(CustomerId, filialId);
		}

		public void Update(Customers entity)
		{
			 _dal.Update(entity);
		}
	}
}
