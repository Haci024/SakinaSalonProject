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
    public class LazerReportConfig : IEntityTypeConfiguration<LazerAppointmentReports>
    {
        public void Configure(EntityTypeBuilder<LazerAppointmentReports> builder)
        {
            builder.HasKey(x=> new {x.AppointmentId,x.CategoryId});
            builder.HasOne(x=>x.LazerAppointment).WithMany(x=>x.LazerAppointmentReports).HasForeignKey(x=>x.AppointmentId);
            builder.HasOne(x => x.LazerCategory).WithMany(x => x.LazerAppointmentReports).HasForeignKey(x => x.CategoryId);
            
        }
    }
}
