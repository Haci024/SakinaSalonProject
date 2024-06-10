using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class CosmetologyAppointment
    {
        public int Id { get; set;}
   
        public Master Master { get; set;}

        public int MasterId { get; set; }

        public int CustomerId { get; set; }

        public Customers Customers { get; set;}

        public decimal Price { get; set;}
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? StartTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? OutTime { get; set; }

        public AppUser AppUser { get; set; }

        public string AppUserId { get; set;}

        public string? CosmetologyDescription { get; set;}

        public bool IsStart { get;set; }

        public bool IsCompleted { get;set; }

        public IEnumerable<CosmetologyReport> CosmetologyReports { get; set;}

        public Filial Filial { get; set;}   

        public int FilialId { get; set; }

      



        

    }
}
