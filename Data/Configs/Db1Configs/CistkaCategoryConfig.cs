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
	public class CistkaCategoryConfig : IEntityTypeConfiguration<CistkaCategory>
	{
		public void Configure(EntityTypeBuilder<CistkaCategory> builder)
		{
			builder.HasKey(x=>x.Id);
			builder.HasMany(x=>x.CistkaReports).WithOne(x=>x.CistkaCategory).HasForeignKey(x=>x.CategoryId);
			builder.HasOne(x => x.MainCategory).WithMany(x => x.ChildCategoryList).HasForeignKey(x => x.MainCategoryId);
			builder.Property(x => x.Price).HasColumnType("decimal(6,2)");
			builder.HasOne(x => x.Filial).WithMany(x => x.CistkaCategory).HasForeignKey(x => x.FilialId);
		}
	}
}
