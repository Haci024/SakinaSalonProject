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
    public class KassaActionCategoryConfig : IEntityTypeConfiguration<KassaActionCategory>
    {
        public void Configure(EntityTypeBuilder<KassaActionCategory> builder)
        {
           builder.HasKey(x=>x.Id);
            builder.HasMany(x=>x.KassaActionList).WithOne(x=>x.KassaActionCategory).HasForeignKey(x=>x.CategoryId);
            //builder.HasOne(x=>x.Filial).WithMany(x=>x.KassActionCategory).HasForeignKey(x=>x.CategoryId);   
        }
    }
}
