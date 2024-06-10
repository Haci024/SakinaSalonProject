using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class MakeUpReports
    {
        public int AppointmentId { get; set; }
        public MakeUpAppointment MakeUpAppointment { get; set; }


        public int CategoryId { get; set; }
        public MakeUpCategory MakeUpCategory { get; set; }

      


    }
}
