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
	public class StockConfig : IEntityTypeConfiguration<Stock>
	{
		public void Configure(EntityTypeBuilder<Stock> builder)
		{
		  builder.HasKey(x => x.Id);
			builder.HasOne(x => x.Filial).WithMany(x => x.Stock).HasForeignKey(x => x.FilialId);
			builder.Property(x=>x.BuyingPrice).HasColumnType("decimal(6,2)");
			builder.Property(x=>x.SellingPrice).HasColumnType("decimal(6,2)");
		}
	}
}
