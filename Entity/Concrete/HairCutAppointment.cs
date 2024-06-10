using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class HairCutAppointment
    {
        public int Id { get; set; }

        public Master Master { get; set; }

        public int MasterId { get; set; }

        public Customers Customers { get; set; }

        public int CustomerId { get; set; }

        public decimal Price { get; set; }

        public int IncomeId { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime ReservationDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime EndTime { get; set; }

        public IEnumerable<HairCutItems> HairCutItems { get; set; }

        public IEnumerable<HairCutCategoryReports> HairCutReport { get; set; }

        public bool HandDescription { get; set; } = false;

        public string? Description { get; set; } = string.Empty;

        public AppUser AppUser { get; set; } 

        public string AppUserId { get; set; }

        public int FilialId { get; set; }

        public Filial Filial { get; set; }



        

       




    }
}
