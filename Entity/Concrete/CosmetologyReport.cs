using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class CosmetologyReport
    {
        public int Id { get; set; }

        public CosmetologyAppointment CosmetologyAppointment { get; set; }

        public int AppointmentId { get; set; }

        public CosmetologyCategory CosmetologyCategory { get; set; }    

        public int CategoryId { get; set; }
    }
}
