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
	public class BodySahpingReportsConfig : IEntityTypeConfiguration<BodyShapingReports>
	{
		public void Configure(EntityTypeBuilder<BodyShapingReports> builder)
		{
			builder.HasKey(x=> new {x.PacketId,x.AppointmentsId});
			builder.HasOne(x=>x.BodyshapingAppointments).WithMany(x=>x.BodyShapingPacketReports).HasForeignKey(x=>x.AppointmentsId);
			builder.HasOne(x => x.BodyShapingPackets).WithMany(x => x.BodyShapingPacketsReports).HasForeignKey(x => x.PacketId);

		}
	}
}
