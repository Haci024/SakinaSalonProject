using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Income
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public int Count { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime IncomeDate { get; set; }

        public decimal Price { get; set; }

        public decimal BuyingPrice { get; set; }

        public string Description { get; set;}

        public AppUser AppUser { get; set; }

        public string AppUserId { get; set; }
         
        public Stock Stock { get; set; }  

        public long StockId { get; set; }

        public Filial Filial { get; set; }

        public int FilialId { get; set; }

        public IEnumerable<HairCutItems> HairCutItems { get; set;}




    }
}
