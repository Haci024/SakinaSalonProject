using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class SolariumUsingList
    {
        public int Id { get; set; }

        public SolariumAppointment SolariumAppointment { get; set; }

        public int  AppointmentId { get; set; }

        public int UsingMinute { get; set; }

        public int RemainingMinute { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime  UsingDate { get; set; }


        public AppUser AppUser { get; set; }

        public string? AppUserId { get; set; }


    }
}
