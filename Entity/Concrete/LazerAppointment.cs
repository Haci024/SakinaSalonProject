using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class LazerAppointment
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime ReservationDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? StartTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? EndTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? InCompleteStartTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? InCompleteEndTime { get; set; }

        public Customers Customers { get; set; }

        public Master Master { get; set; }
      
        public int MasterId { get; set; }

        public int CustomerId { get; set; }

        public decimal  Price { get; set; }

        public IEnumerable<LazerAppointmentReports> LazerAppointmentReports { get; set; }

        public int  ImplusCount { get; set; }

      
      
        public Filial Filial { get; set; }

        public int FilialId { get; set; }

        public string? EditorName { get; set; } = string.Empty;
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? NextSessionDate { get; set; }

        public bool HandDescription { get; set; } = false;

        public AppUser AppUser { get; set; }

        public string AppUserId { get; set; }

        public bool IsReserved { get; set; }

        public bool IsStarted { get; set; }

        public bool IsCompleted { get; set; }

        public bool IsContiued { get; set; } = false;

        public bool IsDeleted { get; set;}

        public string? InjectionDecription { get; set; } = string.Empty;

        public bool StartForSecond { get; set; }

        public bool EndForSecond { get; set; } = false; 

        public bool ReservationForSecond { get; set; } = false;

        public string? PriceUpdateDescription { get; set; }


    }
}
