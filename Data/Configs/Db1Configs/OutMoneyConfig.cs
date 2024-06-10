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
    public class OutMoneyConfig : IEntityTypeConfiguration<OutMoney>
    {
        public void Configure(EntityTypeBuilder<OutMoney> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.AppUser).WithMany(x => x.OutMoney).HasForeignKey(x => x.AppUserId);
            builder.HasOne(x => x.Filial).WithMany(x => x.OutMoney).HasForeignKey(x => x.FilialId);
            builder.HasOne(x => x.SpendCategory).WithMany(x => x.OutMoney).HasForeignKey(x => x.SpendCategoryId);
            builder.Property(x => x.Price).HasColumnType("decimal(6,2)");

        }
    }
}
