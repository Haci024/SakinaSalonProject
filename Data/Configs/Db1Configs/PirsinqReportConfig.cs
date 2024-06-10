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
    public class PirsinqReportConfig:IEntityTypeConfiguration<PirsinqReports>
    {
        public void Configure(EntityTypeBuilder<PirsinqReports> builder)
        {
            builder.HasKey(x => new { x.AppointmentId, x.CategoryId });
            builder.HasOne(x => x.PirsinqAppointment).WithMany(x => x.PirsinqReports).HasForeignKey(x => x.AppointmentId);
            builder.HasOne(x => x.PirsinqCategory).WithMany(x => x.PirsinqReports).HasForeignKey(x => x.CategoryId);
        }


    }
}
