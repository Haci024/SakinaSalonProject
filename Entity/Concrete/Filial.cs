using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public  class Filial
    {
        public int Id { get; set; }

        public string FilialName { get; set; }

        public IEnumerable<LazerAppointment> LazerAppointments { get; set; } 

        public IEnumerable<MasterFilial> MasterFilial { get; set; }

        public IEnumerable<Customers> Customers { get; set; }    

        public IEnumerable<AppUser> AppUser { get; set; }

        public IEnumerable<SolariumAppointment> SolariumAppointments { get; set; }

        public IEnumerable<CosmetologyAppointment> CosmetologyAppointments { get; set; }

        public IEnumerable<BodyshapingAppointment> BodyShapingAppointments { get; set; }

        public IEnumerable<KassaActionList> KassaActionList { get; set;}

        public IEnumerable<Income> Income { get; set; }

        public IEnumerable<Stock> Stock { get; set; }

        public IEnumerable<SpendCategory> SpendCategory { get; set; }

        public IEnumerable<CistkaAppointment> CistkaAppointment { get; set; }

        public IEnumerable<LazerCategory> LazerCategories  { get; set; }

        public IEnumerable<LipuckaAppointment> LipuckaAppointments { get; set; }

        public IEnumerable<LipuckaCategories> LipuckaCategories { get; set; }

        public IEnumerable<PirsinqCategory> PirsinqCategories { get; set; }

        public IEnumerable<PirsinqAppointment> PirsinqAppointments { get; set; }

        public IEnumerable<HairCutAppointment> HairCutAppointments { get; set; }

        public IEnumerable<HairCutCategory> HairCutCategories { get; set; }

        public IEnumerable<MakeUpAppointment> MakeUpAppointments { get; set; }

        public IEnumerable<CistkaCategory> CistkaCategory { get; set;}

        public IEnumerable<MakeUpCategory> MakeUpCategory { get; set; }

		public IEnumerable<OutMoney> OutMoney { get; set; }

		public IEnumerable<KassaActionCategory> KassaActionCategories { get; set; }

    }
}
