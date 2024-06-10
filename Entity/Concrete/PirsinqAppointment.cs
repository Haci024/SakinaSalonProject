﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class PirsinqAppointment
    {
        public int Id { get; set; } 

        public Customers Customers { get; set; }  

        public int CustomerId { get; set; }

        public Master Master { get; set; }

        public int MasterId { get;set; }

        public AppUser AppUser { get; set; }

        public string AppUserId { get; set; }

        public decimal Price { get; set; }

        public decimal ReturnMoney { get; set; }

        

        public DateTime StartTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? EndTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public bool IsDeactive { get; set; }

        public bool IsStart { get; set; }

        public bool IsCompleted { get; set; }

        public Filial Filial { get; set; }

        public int FilialId { get; set; }

        public string? Description { get; set; }

        public IEnumerable<PirsinqReports> PirsinqReports { get;set; }

    }
}
