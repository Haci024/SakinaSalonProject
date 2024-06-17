using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOS.LazerAppointmentDTO
{
    public class LazerReservationDTO
    {
        public decimal Price { get; set; }

        public DateTime ReservationDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get;set; }
        
        public IEnumerable<LazerAppointmentReports> LazerAppointmentReports { get; set; }

        public int FilialId { get; set; }

        public string AppUserId { get; set; }

        public bool IsReserved { get; set; }

        public bool IsStarted { get; set; }

        public bool IsCompleted { get; set; }

        public bool IsDeleted { get; set; }

        public string? PriceUpdateDescription { get; set; }
    }
}
