using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class CistkaReports
    {
        public int Id { get; set; } 

        public CistkaAppointment CistkaAppointment { get; set; }

        public int AppointmentId { get; set; }    

        public CistkaCategory CistkaCategory { get; set; }

        public int CategoryId { get; set; }   
    }
}
