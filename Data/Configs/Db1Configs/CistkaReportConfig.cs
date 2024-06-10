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
	public class CistkaReportConfig : IEntityTypeConfiguration<CistkaReports>
	{
		public void Configure(EntityTypeBuilder<CistkaReports> builder)
		{
			builder.HasKey(x => new {x.AppointmentId,x.CategoryId });
			builder.HasOne(x=>x.CistkaAppointment).WithMany(x=>x.CistkaReports).HasForeignKey(x=>x.AppointmentId);
			builder.HasOne(x=>x.CistkaCategory).WithMany(x=>x.CistkaReports).HasForeignKey(x=>x.CategoryId);	
		}
	}
}
