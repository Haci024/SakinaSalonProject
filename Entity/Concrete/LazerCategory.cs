﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class LazerCategory
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public LazerCategory MainCategory { get; set; }

        public IEnumerable<LazerAppointmentReports> LazerAppointmentReports { get; set; }
        
        public int? MainCategoryId { get; set; }
        
        public IEnumerable<LazerCategory> ChildCategories { get; set; }
        
        public decimal Price { get; set; }

        public Filial Filial { get; set; }

        public int FilialId { get; set; }

        public bool IsDeactive { get; set; }


    }
}
