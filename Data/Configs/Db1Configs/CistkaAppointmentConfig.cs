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
	public class CistkaAppointmentConfig : IEntityTypeConfiguration<CistkaAppointment>
	{
		public void Configure(EntityTypeBuilder<CistkaAppointment> builder)
		{
			builder.HasKey(x => x.Id);
		    builder.HasOne(x=>x.AppUser).WithMany(x=>x.CistkaAppointments).HasForeignKey(x=>x.AppUserId);
			builder.HasOne(x => x.Customers).WithMany(x => x.CistkaAppointments).HasForeignKey(x => x.CustomerId);
			builder.HasMany(x => x.CistkaReports).WithOne(x => x.CistkaAppointment).HasForeignKey(x => x.AppointmentId);
			builder.HasOne(x => x.Filial).WithMany(x => x.CistkaAppointment).HasForeignKey(x => x.FilialId);

		}
	}
}
