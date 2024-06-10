using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configs.Db1Configs
{
    public class CustomerConfig : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.HasKey(x => x.Id);

            
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.BirthDate)
               .HasColumnName("BirthDate")
               .HasColumnType("date")
               .HasConversion(
                   v => v.HasValue ? v.Value.ToString("yyyy-MM-dd") : null,
                   v => DateTime.Parse(v));
            builder.Property(x => x.PhoneNumber)
              .HasColumnName("PhoneNumber")
              .HasMaxLength(15);
            builder.HasMany(x => x.LazerAppointments).WithOne(x => x.Customers);
            builder.HasMany(x => x.BodyshapingAppointments).WithOne(x => x.Customers);
            builder.HasMany(x => x.SolariumAppointments).WithOne(x => x.Customers);
            builder.HasMany(x => x.LipuckaAppointments).WithOne(x => x.Customers);
            builder.HasMany(x => x.PirsinqAppointments).WithOne(x => x.Customers);
            builder.HasMany(x => x.HairCutAppointments).WithOne(x => x.Customers);
            builder.HasMany(x => x.MakeUpAppointments).WithOne(x => x.Customers);
            builder.HasMany(x => x.CistkaAppointments).WithOne(x => x.Customers);
            builder.HasOne(x=>x.Filial).WithMany(x=> x.Customers).HasForeignKey(x=>x.FilialId);

            

        }
    }
}
