using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class HairCutCategory
    {
        
        public int Id { get; set; }

        public HairCutCategory MainCategory { get; set; }

        public IEnumerable<HairCutCategory> ChildCategory { get; set; }

        public IEnumerable<HairCutCategoryReports> HairCutCategoryReports { get; set; }

        public int FilialId { get; set; }   

        public Filial Filial { get; set; }  

        public int? MainCategoryId { get; set; }

        public bool Status { get; set; }

        public decimal? Price { get; set; }

        public bool Discount { get; set; }  



        

    }
}
