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
    public class MakeUpAppointmentConfig : IEntityTypeConfiguration<MakeUpAppointment>
    {
        public void Configure(EntityTypeBuilder<MakeUpAppointment> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Price)
             .HasColumnType("decimal(6,2)");
            builder.HasOne(x=>x.Master).WithMany(x=>x.MakeUpAppointment).HasForeignKey(x=>x.MasterId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.MakeUpAppointments).HasForeignKey(x => x.AppUserId);
            builder.HasOne(x => x.Customers).WithMany(x => x.MakeUpAppointments).HasForeignKey(x => x.CustomerId);
            builder.HasOne(x =>x.Filial).WithMany(x => x.MakeUpAppointments).HasForeignKey(x => x.FilialId);
            builder.HasMany(x => x.MakeUpReports).WithOne(x => x.MakeUpAppointment).HasForeignKey(x => x.AppointmentId);
           
            
            
        }
    }
}
