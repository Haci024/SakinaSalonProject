﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class LipuckaReports
    {
     
        public int Id { get; set; }

        public LipuckaAppointment LipuckaAppointment { get; set; }

        public int AppointmentId { get; set; }   

        public LipuckaCategories LipuckaCategories {  get; set; }

        public int CategoriesId { get; set; }
    }
}
