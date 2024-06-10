using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
     public class Master
    {
        

        public int Id { get; set; }

        public string FullName { get; set; }

        public bool Status { get; set; }

        public IEnumerable<MasterFilial> MasterFilial { get; set; }

       public  IEnumerable<MasterPosition> MasterPosition { get;set; }
       
       public  IEnumerable<LazerAppointment> LazerAppointments { get; set; }
       
        public  IEnumerable<CosmetologyAppointment> CosmetologyAppointment { get; set; }
       
      public  IEnumerable<PirsinqAppointment> PirsinqAppointments { get; set; }
      
      public  IEnumerable<LipuckaAppointment> LipuckaAppointments { get; set; }
      
       public IEnumerable<BodyshapingAppointment> BodyShapingAppointment { get; set; }
      
      public  IEnumerable<HairCutAppointment> HairCutAppointments { get; set; }

      public  IEnumerable<MakeUpAppointment> MakeUpAppointment { get; set; }

      public  IEnumerable<CistkaAppointment> CistkaAppointments { get; set; }



    }
}
