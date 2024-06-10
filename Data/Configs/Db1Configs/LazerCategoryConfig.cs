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
    public class LazerCategoryConfig : IEntityTypeConfiguration<LazerCategory>
    {
        public void Configure(EntityTypeBuilder<LazerCategory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x=>x.LazerAppointmentReports).WithOne(x=>x.LazerCategory).HasForeignKey(x=>x.AppointmentId);
            builder.HasOne(x => x.MainCategory).WithMany(x => x.ChildCategories).HasForeignKey(x => x.MainCategoryId);
            builder.Property(x => x.Price).HasColumnType("decimal(6,2)");
            
            
        }
    }
}
