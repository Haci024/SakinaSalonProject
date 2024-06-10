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
    public class BodyShapingAppointmentConfig : IEntityTypeConfiguration<BodyshapingAppointment>
    {
        public void Configure(EntityTypeBuilder<BodyshapingAppointment> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Price)
             .HasColumnType("decimal(6,2)");
            builder.HasOne(x=>x.Master).WithMany(x=>x.BodyShapingAppointment).HasForeignKey(x=>x.MasterId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.BodyshapingAppointments).HasForeignKey(x => x.AppUserId);
            builder.HasOne(x => x.Customers).WithMany(x => x.BodyshapingAppointments).HasForeignKey(x => x.CustomerId);
            builder.HasMany(x => x.BodyShapingSessionLists).WithOne(x => x.BodyShapingAppointment).HasForeignKey(x => x.AppointmentId);
            builder.HasOne(x => x.Filial).WithMany(x => x.BodyShapingAppointments).HasForeignKey(x => x.FilialId);
            builder.HasMany(x => x.BodyShapingPacketReports).WithOne(x => x.BodyshapingAppointments).HasForeignKey(x => x.AppointmentsId);
            
            
        }
    }
}
