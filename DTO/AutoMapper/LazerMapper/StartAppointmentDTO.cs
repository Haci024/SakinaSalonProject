using Entity.Concrete;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AutoMapper.LazerMapper
{
    public class StartAppointmentDTO
    {
        public DateTime StartTime { get; set; }

        public bool IsStart { get; set; }

        public int EmployeeId { get; set; }

        public IEnumerable<Master> Masters { get; set; }

        public int MasterId { get; set; }   

    }
}
