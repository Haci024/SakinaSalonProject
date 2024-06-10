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
    public class LazerAppointmentConfig : IEntityTypeConfiguration<LazerAppointment>
    {
        public void Configure(EntityTypeBuilder<LazerAppointment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(c => c.Customers) 
               .WithMany(o => o.LazerAppointments)
               .HasForeignKey(o => o.CustomerId);
            builder.HasMany(x => x.LazerAppointmentReports).WithOne(y => y.LazerAppointment).HasForeignKey(x => x.AppointmentId);
            builder.HasOne(x=>x.AppUser).WithMany(x=>x.LazerAppointments).HasForeignKey(x => x.AppUserId);
            builder.Property(x => x.Price)
              .HasColumnType("decimal(6,2)");



        }
    }
}
