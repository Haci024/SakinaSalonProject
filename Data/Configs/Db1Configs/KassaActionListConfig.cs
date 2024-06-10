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
    public class KassaActionListConfig:IEntityTypeConfiguration<KassaActionList>
    {
        public void Configure(EntityTypeBuilder<KassaActionList> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.AppUser).WithMany(x => x.KassaActions).HasForeignKey(x => x.AppUserId);
            builder.HasOne(x=>x.KassaActionCategory).WithMany(x=>x.KassaActionList).HasForeignKey(x=>x.CategoryId);
            builder.Property(x => x.OutMoneyQuantity).HasColumnType("decimal(6,2)");
           

        }

        
    }
}
