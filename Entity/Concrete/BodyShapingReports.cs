using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class BodyShapingReports
    {
        
        public BodyshapingAppointment BodyshapingAppointments { get; set; }

        public int AppointmentsId { get; set; }

        public BodyShapingPackets BodyShapingPackets { get; set; }

        public int PacketId { get; set; }
    }
}
