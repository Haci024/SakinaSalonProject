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
    public class PositionConfig:IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
           builder.HasKey(x=> x.Id);    
           builder.HasMany(x=>x.MasterPositions).WithOne(x=>x.Positions).HasForeignKey(x=>x.PositionId);

        }

       
    }
}
