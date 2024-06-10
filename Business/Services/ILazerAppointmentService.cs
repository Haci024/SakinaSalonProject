using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
	public interface ILazerAppointmentService:IGenericService<LazerAppointment>
	{
		#region Əməliyyatlara uyğun gələn seanslar
		public Task<IQueryable<LazerAppointment>> GetAllReservations(int filialId);

		public Task<IQueryable<LazerAppointment>> DailyAllReservationList(int filialId, int MasterId);

		public Task<IQueryable<LazerAppointment>> ReservationListForMaster(int filialId, int MasterId);

		public Task<IQueryable<LazerAppointment>> AllInjections(int filialId);

		public Task<IQueryable<LazerAppointment>> InjectionListByMaster(int MasterId, int filialId);

		public Task<IQueryable<LazerAppointment>> AllCompletedAppointmentListByMaster(int MasterId, int filialId);

		public Task<IQueryable<LazerAppointment>> KorreksionListByMaster(int MasterId, int filialId);

		public Task<IQueryable<LazerAppointment>> ContinuedAppointmentList(int filialId);
		#endregion

		#region Sorğular

		#region Seanslar
		public Task<IQueryable<LazerAppointment>> SelectAppointmentReportsOnlyDate(DateTime startDate, DateTime endDate, int filialId);

		public Task<IQueryable<LazerAppointment>> SelectAppointmentReportsByStatus(DateTime startDate, DateTime endDate, int statusId, int filialId);

		public Task<IQueryable<LazerAppointment>> SelectAppointmentReportsByMasterAndStatus(DateTime startDate, DateTime endDate, int statusId, int masterId, int filialId);

		public Task<IQueryable<LazerAppointment>> SelectAppointmentReportsByAllFilter(DateTime startDate, DateTime endDate, int statusId, int masterId, int[] categoryId, int filialId);

		#endregion

		#region Impuls
		public Task<double> ImpulsCountOnlyDate(DateTime startDate, DateTime endDate, int statusId, int filialId);

		public Task<double> ImpulsCountByStatus(DateTime startDate, DateTime endDate, int statusId, int filialId);

		public Task<double> ImpulsCountByCategory(DateTime startDate, DateTime endDate, int statusId, int[] categoryId, int filialId);

		public Task<double> ImpulsCountByMasterAndStatus(DateTime startDate, DateTime endDate, int statusId, int filialId);

		public Task<double> ImpulsCountByAllFilter(DateTime startDate, DateTime endDate, int statusId, int masterId, int[] categoryId, int filialId);


		#endregion

		#region Sessions
		public Task<double> SessionCountOnlyDate(DateTime startDate, DateTime endDate, int statusId, int filialId);

		public Task<double> SessionCountByStatus(DateTime startDate, DateTime endDate, int statusId, int filialId);

		public Task<double> SessionCountByCategory(DateTime startDate, DateTime endDate, int statusId, int[] categoryId, int filialId);

		public Task<double> SessionCountByMasterAndStatus(DateTime startDate, DateTime endDate, int statusId, int filialId);

		public Task<double> SessionCountByAllFilter(DateTime startDate, DateTime endDate, int statusId, int masterId, int[] categoryId, int filialId);
		#endregion
		#endregion
	}
}
