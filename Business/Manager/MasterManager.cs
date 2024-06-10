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
	public class MasterManager : IMasterService
	{
		private readonly IMasterDAL _dal;
        public MasterManager(IMasterDAL dal)
        {
			_dal = dal;
        }
        public void Create(Master entity)
		{
			_dal.Create(entity);	
		}

		public void Delete(Master entity)
		{
		   _dal.Delete(entity);
		}

		public Task<Master> GetById(int Id)
		{
		  return  _dal.GetById(Id);
		}

		public Task<IEnumerable<Master>> GetList()
		{
			return _dal.GetList();
		}

		public void Update(Master entity)
		{
			_dal.Update(entity);
		}
	}
}
