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
    public class SpendCategoryConfig : IEntityTypeConfiguration<SpendCategory>
    {
        public void Configure(EntityTypeBuilder<SpendCategory> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.HasMany(x=>x.OutMoney).WithOne(x=>x.SpendCategory).HasForeignKey(x=>x.Id);
            builder.HasOne(x => x.Filial).WithMany(x => x.SpendCategory).HasForeignKey(x => x.Id);
            
          
        }
    }
}
