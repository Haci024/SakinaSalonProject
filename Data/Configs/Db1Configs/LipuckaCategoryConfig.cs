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
    public class LipuckaCategoryConfig : IEntityTypeConfiguration<LipuckaCategories>
    {
        public void Configure(EntityTypeBuilder<LipuckaCategories> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.HasOne(x=>x.MainCategory).WithMany(x=>x.ChildCategories).HasForeignKey(x=>x.MainCategoryId);
            builder.HasMany(x=>x.LipuckaReports).WithOne(x=>x.LipuckaCategories).HasForeignKey(x=>x.CategoriesId);
            builder.Property(x=>x.Price).HasColumnType("decimal(6,2)");
            
            
            

        }
    }
}
