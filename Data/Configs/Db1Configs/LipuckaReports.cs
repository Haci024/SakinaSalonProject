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
    public class LipuckaReportsConfig : IEntityTypeConfiguration<LipuckaReports>
    {
        public void Configure(EntityTypeBuilder<LipuckaReports> builder)
        {

            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.LipuckaCategories).WithMany(x=>x.LipuckaReports).HasForeignKey(x=>x.CategoriesId);
            builder.HasOne(x => x.LipuckaAppointment).WithMany(x=>x.LipuckaReports).HasForeignKey(x=>x.AppointmentId);
            
        }
    }
}
