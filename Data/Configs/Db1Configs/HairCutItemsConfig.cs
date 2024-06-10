using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configs.Db1Configs
{
    public class HairCutItemsConfig : IEntityTypeConfiguration<HairCutItems>
    {
        public void Configure(EntityTypeBuilder<HairCutItems> builder)
        {
            builder.HasKey(x => new { x.StockId,x.AppointmentId });
            builder.HasOne(x=>x.HairCutAppointment).WithMany(x=>x.HairCutItems).HasForeignKey(x=>x.AppointmentId);
            builder.HasOne(x => x.Stock).WithMany(x => x.HairCutItems).HasForeignKey(x => x.StockId);
            
            
        }
    }
}
