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
    public class HairCutReportConfig : IEntityTypeConfiguration<HairCutCategoryReports>
    {
        public void Configure(EntityTypeBuilder<HairCutCategoryReports> builder)
        {
            builder.HasKey(x => new { x.AppointmentId, x.CategoryId });
            builder.HasOne(x=>x.HairCutAppointment).WithMany(x=>x.HairCutReport).HasForeignKey(x=>x.AppointmentId);
            builder.HasOne(x=>x.HairCutCategory).WithMany(x=>x.HairCutCategoryReports).HasForeignKey(x=>x.CategoryId);

        }
    }
}
