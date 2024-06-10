using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class PirsinqCategory
    {
        public int Id { get; set; } 

        public string CategoryName { get; set; }

         public PirsinqCategory MainCategory { get; set; }

        public int? MainCategoryId { get; set; }

        public IEnumerable<PirsinqCategory> ChildCategory { get; set; }

        public decimal Price {  get; set; } 

        public bool IsDeactive {  get; set; }

        public IEnumerable<PirsinqReports> PirsinqReports { get; set; }

        public int FilialId { get; set; }   

        public Filial Filial { get; set; }

    }
}
