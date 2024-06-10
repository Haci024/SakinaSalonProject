using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class HairCutItems
    {
        public int Id { get; set; }

        public HairCutAppointment HairCutAppointment { get; set; }

        public int AppointmentId { get; set; }

        public Stock Stock { get; set; }

        public int? StockId { get;set; }

        


    }
}
