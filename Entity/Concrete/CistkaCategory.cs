using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class CistkaCategory
    {
        public int Id { get; set; } 

        public CistkaCategory MainCategory { get; set; }  

        public IEnumerable<CistkaCategory> ChildCategoryList { get; set; }

        public IEnumerable<CistkaReports> CistkaReports { get; set; }

        public int? MainCategoryId { get; set; } 
       
        public string Category { get; set; }   
        
        public bool Status { get; set; }

        public decimal Price { get; set; }

        public bool Discount { get; set; }

		public Filial Filial { get; set; }

		public int FilialId { get; set; }



	}
}
