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
    public class PirsinqCategoryConfig : IEntityTypeConfiguration<PirsinqCategory>
    {
        public void Configure(EntityTypeBuilder<PirsinqCategory> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.HasOne(x => x.MainCategory).WithMany(x => x.ChildCategory).HasForeignKey(x => x.MainCategoryId);
            builder.HasMany(x => x.ChildCategory).WithOne(x => x.MainCategory).HasForeignKey(x => x.MainCategoryId);
            builder.HasMany(x=>x.PirsinqReports).WithOne(x=>x.PirsinqCategory).HasForeignKey(x=>x.CategoryId);
        }
    }
}
