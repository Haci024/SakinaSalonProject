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
    public class MasterConfig : IEntityTypeConfiguration<Master>
    {
        public void Configure(EntityTypeBuilder<Master> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(m => m.MasterFilial)
                 .WithOne(mf => mf.Master)
                 .HasForeignKey(mf => mf.MasterId);
            builder.HasMany(m => m.MasterPosition)
                .WithOne(mf => mf.Masters)
                .HasForeignKey(mf => mf.MasterId);
            builder.HasMany(x => x.HairCutAppointments).WithOne(x => x.Master).HasForeignKey(x => x.MasterId);
            builder.HasMany(x => x.MakeUpAppointment).WithOne(x => x.Master).HasForeignKey(x => x.MasterId);
            builder.HasMany(x => x.CistkaAppointments).WithOne(x => x.Master).HasForeignKey(x => x.MasterId);
            builder.HasMany(x => x.PirsinqAppointments).WithOne(x => x.Master).HasForeignKey(x => x.MasterId);
            builder.HasMany(x => x.LipuckaAppointments).WithOne(x => x.Master).HasForeignKey(x => x.MasterId);
            builder.HasMany(x => x.BodyShapingAppointment).WithOne(x => x.Master).HasForeignKey(x => x.MasterId);
            builder.HasMany(x => x.CosmetologyAppointment).WithOne(x => x.Master).HasForeignKey(x => x.MasterId);
            builder.HasMany(x => x.LazerAppointments).WithOne(x => x.Master).HasForeignKey(x => x.MasterId);
            
            


        }
    }
}
