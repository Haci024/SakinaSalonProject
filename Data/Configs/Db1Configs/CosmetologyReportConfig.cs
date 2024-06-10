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
    public class CosmetologyReportConfig : IEntityTypeConfiguration<CosmetologyReport>
    {
        public void Configure(EntityTypeBuilder<CosmetologyReport> builder)
        {
            builder.HasKey(x => new {x.AppointmentId,x.CategoryId });
            builder.HasOne(x => x.CosmetologyAppointment).WithMany(x => x.CosmetologyReports).HasForeignKey(x => x.AppointmentId);
            builder.HasOne(x => x.CosmetologyCategory).WithMany(x => x.CosmetologyReports).HasForeignKey(x => x.CategoryId);
            
           

        }
    }


}
