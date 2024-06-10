using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class BodyShapingSessionList
    {
        public int Id { get; set; }

        public  BodyshapingAppointment  BodyShapingAppointment{ get; set; }

        public int AppointmentId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }

        public int Duration { get; set; }

        public string SessionName { get; set; }

        public bool IsCompleted { get; set; } = false;

        public AppUser AppUser { get; set; }   
       
        public string? AppUserId {  get; set; }



    }
}
