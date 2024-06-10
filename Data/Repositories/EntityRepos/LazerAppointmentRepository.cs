using Data.Context;
using Data.DAL.Customer;
using Data.Repositories.Generic;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Db1Repository
{
    public class LazerAppointmentRepository:GenericRepository<LazerAppointment>,ILazerAppointmentDAL
    {
        private readonly AppDbContext _db;
        public LazerAppointmentRepository(AppDbContext db):base(db)
        {
            _db = db;
        }

        public async Task<IQueryable<LazerAppointment>> AllCompletedAppointmentListByMaster(int MasterId, int filialId)
        {
            return  _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.MasterId == MasterId && x.FilialId == filialId);
        }

        public async Task<IQueryable<LazerAppointment>> AllInjections(int filialId)
        {
            return _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.IsDeleted == true && x.FilialId == filialId);
        }

        public async Task<IQueryable<LazerAppointment>> ContinuedAppointmentList(int filialId)
        {
            return _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.IsContiued == true && x.FilialId == filialId).OrderBy(x=>x.EndTime.Value.Date);
        }

        public async Task<IQueryable<LazerAppointment>> ReservationListForMaster(int filialId, int MasterId)
        {
            return _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.IsReserved == true && x.FilialId == filialId).OrderBy(x=>x.ReservationDate.Date);
        }

        public async Task<IQueryable<LazerAppointment>> GetAllReservations(int filialId)
        {
            return _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.IsReserved == true && x.FilialId == filialId).OrderBy(x => x.ReservationDate.Date);
        }

        public async Task<double> ImpulsCountByAllFilter(DateTime startDate, DateTime endDate,int filialId, int statusId, int masterId, int[] categoryId)
        {
            return _db.LazersAppointment.Include(x => x.Master).Include(x => x.LazerAppointmentReports).ThenInclude(x=>x.LazerCategory).Where(x => x.IsReserved == true && x.FilialId == filialId).OrderBy(x => x.ReservationDate.Date).Count();
        }

        public async Task<double> ImpulsCountByCategory(DateTime startDate, DateTime endDate, int statusId, int[] categoryId,int filialId)
        {
            switch (statusId)
            {
                case 1:
					return await _db.LazersAppointment.Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.FilialId == filialId && x.EndTime >= startDate && x.EndTime <= endDate).CountAsync();
					break;
                case 2:
					return await _db.LazersAppointment.Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.FilialId == filialId && x.EndTime >= startDate && x.EndTime <= endDate).CountAsync();
					break;

                case 3:
					return await _db.LazersAppointment.Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.FilialId == filialId && x.EndTime >= startDate && x.EndTime <= endDate).CountAsync();
					break;

                default:
					return await _db.LazersAppointment.Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.FilialId == filialId && x.EndTime >= startDate && x.EndTime <= endDate).CountAsync();
					break;

            }
          
        }

        public Task<double> ImpulsCountByMasterAndStatus(DateTime startDate, DateTime endDate, int statusId)
        {
            throw new NotImplementedException();
        }

        public Task<double> ImpulsCountByStatus(DateTime startDate, DateTime endDate, int statusId)
        {
            throw new NotImplementedException();
        }

        public Task<double> ImpulsCountOnlyDate(DateTime startDate, DateTime endDate,int statusId)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<LazerAppointment>> InjectionListByMaster(int MasterId, int filialId)
        {
            return  _db.LazersAppointment.Include(x=>x.Master).Include(x=>x.LazerAppointmentReports).ThenInclude(x=>x.LazerCategory).Where(x=>x.MasterId==MasterId && x.FilialId==filialId);
        }

        public async Task<IQueryable<LazerAppointment>> KorreksionListByMaster(int MasterId, int filialId)
        {
			return _db.LazersAppointment.Include(x => x.Master).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.MasterId == MasterId && x.FilialId == filialId);
		}

        public async Task<IQueryable<LazerAppointment>> ReservationListByMaster(int filialId, int MasterId)
        {
            return _db.LazersAppointment.Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Include(x => x.AppUser).Include(x => x.Customers).Include(x => x.AppUser).Where(x => x.IsReserved == true || x.IsCompleted == false && x.MasterId == MasterId && x.FilialId == filialId);
        }

        public async Task<IQueryable<LazerAppointment>> SelectAppointmentReportsByAllFilter(DateTime startDate, DateTime endDate, int statusId, int masterId, int[] categoryId, int filialId)
        {
            switch(statusId)
            {
                case 1:
                    return  _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x=>x.IsCompleted==true && x.EndTime>=startDate && x.EndTime<=endDate && x.FilialId==filialId);
                 break;
                case 2:
                    return _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.IsDeleted == true && x.EndTime >= startDate && x.EndTime <= endDate && x.FilialId == filialId);
                    break;

                default:
                    return _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.IsContiued == true && x.EndTime >= startDate && x.EndTime <= endDate && x.FilialId == filialId);
                  break ;
            }
        }

        public async Task<IQueryable<LazerAppointment>> SelectAppointmentReportsByMasterAndStatus(DateTime startDate, DateTime endDate, int statusId, int masterId, int filialId)
        {
            switch (statusId)
            {
                case 1:
                    return _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.IsCompleted == true && x.MasterId==masterId && x.EndTime >= startDate && x.EndTime <= endDate && x.FilialId == filialId);
                    break;
                case 2:
                    return _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.IsDeleted == true && x.MasterId==masterId  && x.EndTime >= startDate && x.EndTime <= endDate && x.FilialId == filialId);
                    break;

                default:
                    return _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.IsContiued == true && x.MasterId==masterId && x.EndTime >= startDate && x.EndTime <= endDate && x.FilialId == filialId);
                  break;
            }
        }

        public async Task<IQueryable<LazerAppointment>> SelectAppointmentReportsByStatus(DateTime startDate, DateTime endDate, int statusId,int masterId, int filialId)
        {
            switch(statusId) { 
                     case 1:
                return _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.IsCompleted == true && x.MasterId == masterId && x.EndTime >= startDate && x.EndTime <= endDate && x.FilialId == filialId);
                break;
            case 2:
                return _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.IsDeleted == true && x.MasterId == masterId && x.EndTime >= startDate && x.EndTime <= endDate && x.FilialId == filialId);
                break;

            default:
                return _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.IsContiued == true && x.MasterId == masterId && x.EndTime >= startDate && x.EndTime <= endDate && x.FilialId == filialId);
                break;
            }
        }
        public async Task<IQueryable<LazerAppointment>> SelectAppointmentReportsOnlyDate(DateTime startDate, DateTime endDate,int filialId)
        {
            throw new NotImplementedException();
        }

        public async Task<double> SessionCountByAllFilter(DateTime startDate, DateTime endDate, int statusId, int masterId, int[] categoryId, int filialId)
        {
            throw new NotImplementedException();
        }

        public async Task<double> SessionCountByCategory(DateTime startDate, DateTime endDate, int statusId, int[] categoryId, int filialId)
        {
            throw new NotImplementedException();
        }

        public async Task<double> SessionCountByMasterAndStatus(DateTime startDate, DateTime endDate, int statusId, int filialId)
        {
            throw new NotImplementedException();
        }

        public async Task<double> SessionCountByStatus(DateTime startDate, DateTime endDate, int statusId, int filialId)
        {
            switch (statusId)
            {
                case 1:
                    return _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.IsCompleted == true  && x.EndTime >= startDate && x.EndTime <= endDate && x.FilialId == filialId).Count();
                    break;
                case 2:
                    return _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.IsDeleted == true && x.EndTime >= startDate && x.EndTime <= endDate && x.FilialId == filialId).Count();
                    break;
                default:
                    return _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.IsContiued == true && x.EndTime >= startDate && x.EndTime <= endDate && x.FilialId == filialId).Count();
                    break;
            }
        }

        public async Task<double> SessionCountOnlyDate(DateTime startDate, DateTime endDate, int filialId)
        {


            return _db.LazersAppointment.Include(x => x.Master).Include(x => x.Customers).Include(x => x.AppUser).Include(x => x.LazerAppointmentReports).ThenInclude(x => x.LazerCategory).Where(x => x.IsContiued == true && x.EndTime >= startDate && x.EndTime <= endDate && x.FilialId == filialId).Count();
        }

        public Task<IQueryable<LazerAppointment>> DailyAllReservationList(int filialId, int MasterId)
        {
            throw new NotImplementedException();
        }

        public Task<double> ImpulsCountOnlyDate(DateTime startDate, DateTime endDate, int statusId, int filialId)
        {
            throw new NotImplementedException();
        }

        public Task<double> ImpulsCountByStatus(DateTime startDate, DateTime endDate, int statusId, int filialId)
        {
            throw new NotImplementedException();
        }

       
        public Task<double> ImpulsCountByMasterAndStatus(DateTime startDate, DateTime endDate, int statusId, int filialId)
        {
            throw new NotImplementedException();
        }

        public Task<double> ImpulsCountByAllFilter(DateTime startDate, DateTime endDate, int statusId, int masterId, int[] categoryId, int filialId)
        {
            throw new NotImplementedException();
        }

        public Task<double> SessionCountOnlyDate(DateTime startDate, DateTime endDate, int statusId, int filialId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<LazerAppointment>> SelectAppointmentReportsByStatus(DateTime startDate, DateTime endDate, int statusId, int filialId)
        {
            throw new NotImplementedException();
        }
    }
}
