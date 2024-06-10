using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class LazerAppointmentReports
    {
        public LazerCategory LazerCategory { get; set; }

        public int CategoryId { get; set; }

        public LazerAppointment LazerAppointment { get; set; }

        public int AppointmentId { get; set; }

       
    }
}
