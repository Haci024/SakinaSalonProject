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
    public class IncomeConfig : IEntityTypeConfiguration<Income>
    {
        public void Configure(EntityTypeBuilder<Income> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.HasOne(x=>x.AppUser).WithMany(x=>x.Incomes).HasForeignKey(x=>x.AppUserId);
            builder.HasOne(x => x.Filial).WithMany(x => x.Income).HasForeignKey(x => x.FilialId);
            builder.HasOne(x => x.Stock).WithMany(x => x.Incomes).HasForeignKey(x => x.StockId);
            builder.Property(x => x.Price).HasColumnType("Decimal(6,2)");
            
        }
    }
}
