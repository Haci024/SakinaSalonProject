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
        public void Create(Customers entity)
		{
		_dal.Create(entity);
		}

		public void Delete(Customers entity)
		{
			_dal.Delete(entity);
		}

		public Task<Customers> GetById(int Id)
		{
			return _dal.GetById(Id);
		}

		public Task<IEnumerable<Customers>> GetList()
		{
			return _dal.GetList();
		}

		public void Update(Customers entity)
		{
			 _dal.Update(entity);
		}
	}
}
