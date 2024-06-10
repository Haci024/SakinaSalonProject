using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class PirsinqReports
    {
        public PirsinqAppointment PirsinqAppointment { get; set; }
       
        public int AppointmentId { get; set; }

        public PirsinqCategory PirsinqCategory { get; set;}

        public int CategoryId { get;set; }


    }
}
