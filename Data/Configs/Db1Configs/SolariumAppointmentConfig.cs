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
    public class SolariumAppointmentConfig : IEntityTypeConfiguration<SolariumAppointment>
    {
        public void Configure(EntityTypeBuilder<SolariumAppointment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.Filial).WithMany(x=>x.SolariumAppointments).HasForeignKey(x=>x.FilialId);
            builder.HasMany(x => x.SolariumUsingList).WithOne(x => x.SolariumAppointment).HasForeignKey(x => x.AppointmentId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.SolariumAppointments).HasForeignKey(x => x.AppUserId);
            builder.Property(x => x.Price).HasColumnType("decimal(6,2)");
            builder.Property(x => x.ReturnMoney).HasColumnType("decimal(6,2)");
        }
    }
}
