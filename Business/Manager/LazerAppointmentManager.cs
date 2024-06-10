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

		public Task<IQueryable<LazerAppointment>> AllCompletedAppointmentListByMaster(int MasterId, int filialId)
		{
			throw new NotImplementedException();
		}

		public Task<IQueryable<LazerAppointment>> AllInjections(int filialId)
		{
			throw new NotImplementedException();
		}

		public Task<IQueryable<LazerAppointment>> ContinuedAppointmentList(int filialId)
		{
			throw new NotImplementedException();
		}

		public void Create(LazerAppointment entity)
		{
			_dal.Create(entity);	
		}

		public Task<IQueryable<LazerAppointment>> DailyAllReservationList(int filialId, int MasterId)
		{
			throw new NotImplementedException();
		}

		public void Delete(LazerAppointment entity)
		{
			_dal.Delete(entity);
		}

		public Task<IQueryable<LazerAppointment>> GetAllReservations(int filialId)
		{
			return _dal.GetAllReservations(filialId);
		}

		public Task<LazerAppointment> GetById(int Id)
		{
			return _dal.GetById(Id);	
		}

		public Task<IEnumerable<LazerAppointment>> GetList()
		{
			return _dal.GetList();
		}

		public Task<double> ImpulsCountByAllFilter(DateTime startDate, DateTime endDate, int statusId, int masterId, int[] categoryId, int filialId)
		{
			throw new NotImplementedException();
		}

		public Task<double> ImpulsCountByCategory(DateTime startDate, DateTime endDate, int statusId, int[] categoryId, int filialId)
		{
			throw new NotImplementedException();
		}

		public Task<double> ImpulsCountByMasterAndStatus(DateTime startDate, DateTime endDate, int statusId, int filialId)
		{
			throw new NotImplementedException();
		}

		public Task<double> ImpulsCountByStatus(DateTime startDate, DateTime endDate, int statusId, int filialId)
		{
			throw new NotImplementedException();
		}

		public Task<double> ImpulsCountOnlyDate(DateTime startDate, DateTime endDate, int statusId, int filialId)
		{
			throw new NotImplementedException();
		}

		public Task<IQueryable<LazerAppointment>> InjectionListByMaster(int MasterId, int filialId)
		{
			throw new NotImplementedException();
		}

		public Task<IQueryable<LazerAppointment>> KorreksionListByMaster(int MasterId, int filialId)
		{
			throw new NotImplementedException();
		}

		public Task<IQueryable<LazerAppointment>> ReservationListForMaster(int filialId, int MasterId)
		{
			throw new NotImplementedException();
		}

		public Task<IQueryable<LazerAppointment>> SelectAppointmentReportsByAllFilter(DateTime startDate, DateTime endDate, int statusId, int masterId, int[] categoryId, int filialId)
		{
			throw new NotImplementedException();
		}

		public Task<IQueryable<LazerAppointment>> SelectAppointmentReportsByMasterAndStatus(DateTime startDate, DateTime endDate, int statusId, int masterId, int filialId)
		{
			throw new NotImplementedException();
		}

		public Task<IQueryable<LazerAppointment>> SelectAppointmentReportsByStatus(DateTime startDate, DateTime endDate, int statusId, int filialId)
		{
			throw new NotImplementedException();
		}

		public Task<IQueryable<LazerAppointment>> SelectAppointmentReportsOnlyDate(DateTime startDate, DateTime endDate, int filialId)
		{
			throw new NotImplementedException();
		}

		public Task<double> SessionCountByAllFilter(DateTime startDate, DateTime endDate, int statusId, int masterId, int[] categoryId, int filialId)
		{
			throw new NotImplementedException();
		}

		public Task<double> SessionCountByCategory(DateTime startDate, DateTime endDate, int statusId, int[] categoryId, int filialId)
		{
			throw new NotImplementedException();
		}

		public Task<double> SessionCountByMasterAndStatus(DateTime startDate, DateTime endDate, int statusId, int filialId)
		{
			throw new NotImplementedException();
		}

		public Task<double> SessionCountByStatus(DateTime startDate, DateTime endDate, int statusId, int filialId)
		{
			throw new NotImplementedException();
		}

		public Task<double> SessionCountOnlyDate(DateTime startDate, DateTime endDate, int statusId, int filialId)
		{
			throw new NotImplementedException();
		}

		public void Update(LazerAppointment entity)
		{
		 _dal.Update(entity);
		}
	}
}
