using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class MasterFilial
    {
        public int MasterId { get; set; }
        public Master Master { get; set; }

        public int FilialId { get; set; }
        public Filial Filial { get; set; }
    }
}
