using Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configs.Db1Configs
{
    public class MasterFilialConfig : IEntityTypeConfiguration<MasterFilial>
    {
        public void Configure(EntityTypeBuilder<MasterFilial> builder)
        {
           
            builder.HasKey(mf => new { mf.MasterId, mf.FilialId });

            builder.HasOne(mf => mf.Filial)
                   .WithMany(f => f.MasterFilial)
                   .HasForeignKey(mf => mf.FilialId);

            builder.HasOne(mf => mf.Master)
                  .WithMany(f => f.MasterFilial)
                  .HasForeignKey(mf => mf.FilialId);

        }
    }

}
