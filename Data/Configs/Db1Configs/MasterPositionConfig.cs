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
    public class MasterPositionConfig : IEntityTypeConfiguration<MasterPosition>
    {
        public void Configure(EntityTypeBuilder<MasterPosition> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.HasOne(x => x.Positions).WithMany(x => x.MasterPositions).HasForeignKey(x => x.PositionId);
            builder.HasOne(x => x.Masters).WithMany(x => x.MasterPosition).HasForeignKey(x => x.MasterId);
        }
    }
}
