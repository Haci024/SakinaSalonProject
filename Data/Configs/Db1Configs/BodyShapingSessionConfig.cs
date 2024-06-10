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
    public class BodyShapingSessionConfig : IEntityTypeConfiguration<BodyShapingSessionList>
    {
        public void Configure(EntityTypeBuilder<BodyShapingSessionList> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.AppUser).WithMany(x=>x.BodyShapingSessionList).HasForeignKey(x=>x.AppointmentId);
            builder.HasOne(x=>x.BodyShapingAppointment).WithMany(x=>x.BodyShapingSessionLists).HasForeignKey(x=>x.AppointmentId);
            
            
        }
    }
}
