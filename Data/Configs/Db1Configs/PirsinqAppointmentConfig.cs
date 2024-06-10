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
    public class PirsinqAppointmentConfig : IEntityTypeConfiguration<PirsinqAppointment>
    {
        public void Configure(EntityTypeBuilder<PirsinqAppointment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.AppUser).WithMany(x => x.PirsinqAppointments).HasForeignKey(x => x.AppUserId);
            builder.HasOne(x => x.Customers).WithMany(x => x.PirsinqAppointments).HasForeignKey(x => x.CustomerId);
            builder.HasOne(x => x.Master).WithMany(x => x.PirsinqAppointments).HasForeignKey(x => x.MasterId);
            builder.HasMany(x => x.PirsinqReports).WithOne(x => x.PirsinqAppointment).HasForeignKey(x => x.AppointmentId);
            builder.Property(x => x.Price).HasColumnType("decimal(6,2)");
            builder.Property(x => x.ReturnMoney).HasColumnType("decimal(6,2)");
          
        }
    }
}
