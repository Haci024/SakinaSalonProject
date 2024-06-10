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
    public class MakeUpCategoryConfig : IEntityTypeConfiguration<MakeUpCategory>
    {
        public void Configure(EntityTypeBuilder<MakeUpCategory> builder)
        {
            builder.HasKey(c => c.Id);  
            builder.HasMany(x=>x.MakeUpReports).WithOne(x=>x.MakeUpCategory).HasForeignKey(x=>x.CategoryId);
            builder.HasOne(x => x.MainCategory).WithMany(x => x.ChildCategories).HasForeignKey(x => x.MainCategoryId);
            builder.Property(x => x.Price)
           .HasColumnType("decimal(6,2)");

        }
    }
}
