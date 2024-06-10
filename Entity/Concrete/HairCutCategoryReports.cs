using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class HairCutCategoryReports
    {
      
        public HairCutAppointment HairCutAppointment { get; set; }

        public int AppointmentId { get; set; }

        public HairCutCategory HairCutCategory { get; set; }

        public int CategoryId {get;set; }
    }
}
