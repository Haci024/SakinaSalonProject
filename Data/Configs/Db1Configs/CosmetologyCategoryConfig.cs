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
	public class CosmetologyCategoryConfig : IEntityTypeConfiguration<CosmetologyCategory>
	{
		public void Configure(EntityTypeBuilder<CosmetologyCategory> builder)
		{
			builder.HasKey(x => x.Id);
			builder.HasMany(x => x.CosmetologyReports).WithOne(x => x.CosmetologyCategory).HasForeignKey(x => x.CategoryId);
			builder.HasOne(x => x.MainCategory).WithMany(x => x.ChildCategory).HasForeignKey(x => x.MainCategoryId);
			builder.Property(x => x.Price)
			.HasColumnType("decimal(6,2)");
		}
	}
}
