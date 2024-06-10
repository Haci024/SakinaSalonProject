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
    public class BodyShapingPacketConfig : IEntityTypeConfiguration<BodyShapingPackets>
    {
        public void Configure(EntityTypeBuilder<BodyShapingPackets> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.MainCategory).WithMany(x=>x.ChildCategory).HasForeignKey(x=>x.Id);
            builder.HasMany(x => x.ChildCategory).WithOne(x => x.MainCategory).HasForeignKey(x => x.Id);
            builder.HasOne(x => x.MainCategory).WithMany(x=>x.ChildCategory).HasForeignKey(x=>x.Id);
            builder.HasMany(x => x.BodyShapingPacketsReports).WithOne(x=>x.BodyShapingPackets).HasForeignKey(x=>x.PacketId);
            builder.Property(x => x.Price)
       .HasColumnType("decimal(6,2)");
        }
    }
}
