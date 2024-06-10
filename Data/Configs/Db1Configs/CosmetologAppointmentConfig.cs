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
    public class CosmetologAppointmentConfig:IEntityTypeConfiguration<CosmetologyAppointment>
    {
      

        public void Configure(EntityTypeBuilder<CosmetologyAppointment> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.HasOne(x => x.AppUser).WithMany(x => x.CosmetologyAppointments).HasForeignKey(x => x.AppUserId);
            builder.HasMany(x => x.CosmetologyReports).WithOne(x => x.CosmetologyAppointment).HasForeignKey(x => x.AppointmentId);
            builder.HasOne(x => x.Customers).WithMany(x => x.CosmetologyAppointments).HasForeignKey(x => x.CustomerId);
            builder.HasOne(x => x.Master).WithMany(x => x.CosmetologyAppointment).HasForeignKey(x => x.MasterId);
            builder.Property(x => x.Price)
             .HasColumnType("decimal(6,2)");
        }
    }
}
