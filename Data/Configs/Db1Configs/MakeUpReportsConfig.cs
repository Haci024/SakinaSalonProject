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
    public class MakeUpReportsConfig : IEntityTypeConfiguration<MakeUpReports>
    {
        public void Configure(EntityTypeBuilder<MakeUpReports> builder)
        {

        builder.HasKey(mf => new { mf.AppointmentId, mf.CategoryId });
        builder.HasOne(x=>x.MakeUpAppointment).WithMany(x=>x.MakeUpReports).HasForeignKey(x=>x.AppointmentId);
        builder.HasOne(x => x.MakeUpCategory).WithMany(x => x.MakeUpReports).HasForeignKey(x => x.CategoryId);
        

            
        }
    }
}
