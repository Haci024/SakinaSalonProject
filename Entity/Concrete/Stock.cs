using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Stock
    {
        public long Id { get; set; }

        public string ProductName { get; set; }

        public int TotalCount { get; set; }   

        public int SellingCount { get;set; }
        
        public int RemainCount { get; set; }

        public DateTime AddingDate { get; set; }

        public IEnumerable<Income> Incomes { get; set; }

        public AppUser AppUser { get; set; }    

        public string AppUserId { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal BuyingPrice { get; set; }

        public Filial Filial { get; set; }

        public int FilialId { get; set; }

        public IEnumerable<HairCutItems> HairCutItems { get; set; }



    }
}
