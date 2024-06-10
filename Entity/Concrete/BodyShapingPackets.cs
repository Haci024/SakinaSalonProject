using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class BodyShapingPackets
    {
        public int Id { get; set; }

        public string Packet { get; set; }

        public BodyShapingPackets MainCategory { get; set; }

        public IEnumerable<BodyShapingPackets> ChildCategory { get; set; }

        public int? MainCategoryId { get; set; }

        public int? SessionCount { get; set; }

        public int? SessionDuration { get; set; }

        public IEnumerable<BodyShapingReports> BodyShapingPacketsReports { get; set; }

        public decimal? Price { get; set; }

        public bool IsDeactive { get; set; }

        public bool Discount { get; set; }  



    }
}
