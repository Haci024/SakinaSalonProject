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
    public class SolariumSessionListConfig : IEntityTypeConfiguration<SolariumUsingList>
    {
        public void Configure(EntityTypeBuilder<SolariumUsingList> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.AppUser).WithMany(x=>x.SolariumUsingList).HasForeignKey(x=>x.AppUserId);
            builder.HasOne(x=>x.SolariumAppointment).WithMany(x=>x.SolariumUsingList).HasForeignKey(x=>x.AppointmentId);
            
        }
    }
}
