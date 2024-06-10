using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
  public class AppUser:IdentityUser<string>
    {

        public string FullName { get; set; }

        public string ForgetPasswordCode  { get; set;}

        public bool IsBlock { get; set; } = false;

        public Filial Filial { get; set; } 

        public int FilialId { get; set;}

        public  IEnumerable<LazerAppointment> LazerAppointments { get; set;}

        public IEnumerable<SolariumAppointment> SolariumAppointments { get;set;}

        public IEnumerable<BodyshapingAppointment> BodyshapingAppointments { get; set; }

        public IEnumerable<SolariumUsingList> SolariumUsingList { get; set; }

        public IEnumerable<BodyShapingSessionList> BodyShapingSessionList { get; set; }

        public IEnumerable<CosmetologyAppointment> CosmetologyAppointments { get; set; }

        public IEnumerable<HairCutAppointment> HairCutAppointments { get; set; }

        public IEnumerable<CistkaAppointment> CistkaAppointments { get; set; }

        public IEnumerable<PirsinqAppointment> PirsinqAppointments { get; set; }

        public IEnumerable<LipuckaAppointment> LipuckaAppointments { get; set; }

        public IEnumerable<KassaActionList> KassaActions { get; set; }

        public IEnumerable<MakeUpAppointment> MakeUpAppointments { get; set; }

        public IEnumerable<Income> Incomes { get; set; }

        public IEnumerable<OutMoney> OutMoney { get; set; }

    }
}
