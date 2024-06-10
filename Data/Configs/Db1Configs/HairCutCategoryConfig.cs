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
    public class HairCutCategoryConfig : IEntityTypeConfiguration<HairCutCategory>
    {
        public void Configure(EntityTypeBuilder<HairCutCategory> builder)
        {
            builder.HasKey(x =>x.Id);
            builder.HasMany(x=>x.HairCutCategoryReports).WithOne(x=>x.HairCutCategory).HasForeignKey(x=>x.CategoryId);
            builder.HasOne(x=>x.MainCategory).WithMany(x=>x.ChildCategory).HasForeignKey(x=>x.MainCategoryId);
            builder.Property(x => x.Price)
         .HasColumnType("decimal(6,2)");

        }
    }

}
