using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class MasterPosition
    {
        public int Id { get; set; }

        public Master Masters { get; set; }

        public int MasterId { get; set; }

        public Position Positions { get; set; }
       
        public int PositionId { get; set; }
    }
}
