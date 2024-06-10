using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class MakeUpCategory
    {
        public int Id { get; set; } 

        public string Name { get; set; }

        public MakeUpCategory MainCategory { get; set;}

        public IEnumerable<MakeUpCategory> ChildCategories { get; set;}

        public IEnumerable<MakeUpReports> MakeUpReports { get; set; }

        public int? MainCategoryId { get; set;}

        public decimal Price { get; set; }

        public bool Status { get; set; }

        public Filial Filial { get; set; }

        public int FilialId { get; set; }
    }
}
