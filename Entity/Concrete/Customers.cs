using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Customers
    {
        public int Id { get; set; }

        public IEnumerable<LazerAppointment> LazerAppointments { get; set; }

        public IEnumerable<SolariumAppointment> SolariumAppointments { get; set; }

        public IEnumerable<BodyshapingAppointment> BodyshapingAppointments { get; set; }

        public IEnumerable<HairCutAppointment> HairCutAppointments { get; set; }

        public IEnumerable<MakeUpAppointment> MakeUpAppointments { get; set; }

        public IEnumerable<PirsinqAppointment> PirsinqAppointments { get; set; }
      
        public IEnumerable<LipuckaAppointment> LipuckaAppointments { get; set; }

        public IEnumerable<CosmetologyAppointment> CosmetologyAppointments { get; set; }

        public IEnumerable<CistkaAppointment> CistkaAppointments { get; set; }

        public DateTime? BirthDate { get; set; }

        public string FullName { get; set; }
        
        public double? PhoneNumber { get; set; }

        public bool GiveNumber { get; set; }

        public bool GiveBirthDate { get; set; }

        public bool Female { get; set; }

        public Filial Filial { get; set; }

        public int FilialId { get; set; }

        public bool Status { get;set; }
         
    }
}
