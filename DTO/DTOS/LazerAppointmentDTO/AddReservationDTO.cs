using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOS.LazerAppointmentDTO
{
    public class AddReservationDTO
    {
        public bool StartAlready { get; set; }

        public int CustomerId { get; set; }

        public int EmployeeId { get; set; }

        public DateTime ReservationDate { get; set; }

        public int[] CategoryId { get; set; }

        public decimal Price { get; set; }

        
        
    }
}
