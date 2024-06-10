using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class LipuckaCategories
    {
       public int Id { get; set; }  

        public string Category { get; set; }

        public LipuckaCategories MainCategory { get; set; }

        public IEnumerable<LipuckaCategories> ChildCategories { get; set; }

        public IEnumerable<LipuckaReports> LipuckaReports { get; set; }

        public int? MainCategoryId { get; set; }

        public decimal Price { get; set; }

        public bool Status { get; set; }=false;
    }
}
