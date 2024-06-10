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
    public class FilialConfig : IEntityTypeConfiguration<Filial>
    {
        public void Configure(EntityTypeBuilder<Filial> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(m => m.MasterFilial)
                .WithOne(mf => mf.Filial)
                .HasForeignKey(mf => mf.FilialId);
            builder.HasMany(x => x.MasterFilial).WithOne(x => x.Filial).HasForeignKey(x => x.FilialId);
            builder.HasMany(x => x.HairCutCategories).WithOne(x => x.Filial).HasForeignKey(x => x.FilialId);
            builder.HasMany(x => x.LazerAppointments).WithOne(x => x.Filial).HasForeignKey(x => x.FilialId);
            builder.HasMany(x => x.HairCutAppointments).WithOne(x => x.Filial).HasForeignKey(x => x.FilialId);
            builder.HasMany(x => x.PirsinqCategories).WithOne(x => x.Filial).HasForeignKey(x => x.FilialId);
            builder.HasMany(x => x.BodyShapingAppointments).WithOne(x => x.Filial).HasForeignKey(x => x.FilialId);
            builder.HasMany(x => x.PirsinqAppointments).WithOne(x => x.Filial).HasForeignKey(x => x.FilialId);
            builder.HasMany(x => x.LazerCategories).WithOne(x => x.Filial).HasForeignKey(x => x.FilialId);
            builder.HasMany(x => x.AppUser).WithOne(x => x.Filial).HasForeignKey(x => x.FilialId);
            builder.HasMany(x => x.Customers).WithOne(x => x.Filial).HasForeignKey(x => x.FilialId);
            builder.HasMany(x => x.MakeUpAppointments).WithOne(x => x.Filial).HasForeignKey(x => x.FilialId);
            builder.HasMany(x=>x.MakeUpCategory).WithOne(x=>x.Filial).HasForeignKey(x=>x.FilialId);
            builder.HasMany(x => x.CistkaAppointment).WithOne(x => x.Filial).HasForeignKey(x => x.FilialId);
            builder.HasMany(x => x.CosmetologyAppointments).WithOne(x => x.Filial).HasForeignKey(x => x.FilialId);
            builder.HasMany(x => x.PirsinqAppointments).WithOne(x => x.Filial).HasForeignKey(x => x.FilialId);
            builder.HasMany(x=>x.LipuckaAppointments).WithOne(x=>x.Filial).HasForeignKey(x=>x.FilialId);
            builder.HasMany(x => x.KassaActionList).WithOne(x => x.Filial).HasForeignKey(x => x.FilialId);

        }
    }
}
