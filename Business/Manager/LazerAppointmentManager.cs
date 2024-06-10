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
	public class LazerAppointmentManager : ILazerAppointmentService
	{
		private readonly ILazerAppointmentDAL _dal;
        public LazerAppointmentManager(ILazerAppointmentDAL dal)
        {
            _dal = dal;
        }
        public void Create(LazerAppointment entity)
		{
			_dal.Create(entity);	
		}

		public void Delete(LazerAppointment entity)
		{
			_dal.Delete(entity);
		}

		public Task<LazerAppointment> GetById(int Id)
		{
			return _dal.GetById(Id);	
		}

		public Task<IEnumerable<LazerAppointment>> GetList()
		{
			return _dal.GetList();
		}

		public void Update(LazerAppointment entity)
		{
		 _dal.Update(entity);
		}
	}
}
