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
    public class HairCutAppointmentConfig : IEntityTypeConfiguration<HairCutAppointment>
    {
        public void Configure(EntityTypeBuilder<HairCutAppointment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Price)
            .HasColumnType("decimal(6,2)");
            builder.HasOne(x => x.Master).WithMany(x=>x.HairCutAppointments).HasForeignKey(x => x.MasterId);
            builder.HasOne(x => x.Customers).WithMany(x => x.HairCutAppointments).HasForeignKey(x => x.CustomerId);
            builder.HasOne(x => x.Filial).WithMany(x => x.HairCutAppointments).HasForeignKey(x => x.FilialId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.HairCutAppointments).HasForeignKey(x => x.AppUserId);
            builder.HasMany(x => x.HairCutReport).WithOne(x => x.HairCutAppointment).HasForeignKey(x => x.CategoryId);
           
        }
    }
}
