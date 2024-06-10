using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class CistkaAppointment
    {
        public int Id { get; set; }

        public Master Master { get; set; }

        public int MasterId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime StartDate {  get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime ReservationDate { get; set; }

        public decimal Price { get; set; }

        public bool IsInjection { get; set; }

        public bool IsCompleted {  get; set; }

        public bool IsReserved { get; set; }

        public bool IsStarted { get; set; }     

        public Customers Customers { get; set; }
       
        public int FilialId { get; set; }   

        public Filial Filial { get; set; }

        public int CustomerId { get; set; }

        public bool HandDescription { get; set; } = false;

        public string? Description { get; set; }

        public decimal ReturnMoney { get; set; }

        
    }
}
