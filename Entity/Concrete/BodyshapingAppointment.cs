using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class BodyshapingAppointment
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public Customers Customers { get; set; }

        public decimal Price { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime BuyingDate { get; set; }

        public IEnumerable<BodyShapingSessionList> BodyShapingSessionLists { get; set; }

        public IEnumerable<BodyShapingReports> BodyShapingPacketReports { get; set; }

        public Filial Filial { get; set; }

        public int FilialId { get; set; }

        public Master Master { get; set; }

        public int MasterId { get; set;}

        public AppUser AppUser { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime RemaingDate { get; set; }

        public bool IsCompleted { get; set; }

        public bool IsDeactive { get; set; }

        public string AppUserId { get; set; }    

        public bool IsInjection { get; set; }

        public decimal ReturnMoney { get; set; } = 0;
    }
}
