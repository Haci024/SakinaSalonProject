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
	public class AppUserConfig : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
			builder.HasKey(x=>x.Id);
			builder.HasMany(x => x.LazerAppointments).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
			builder.HasMany(x => x.CosmetologyAppointments).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
			builder.HasMany(x => x.BodyshapingAppointments).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
			builder.HasMany(x => x.SolariumAppointments).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
			builder.HasMany(x => x.SolariumUsingList).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
			builder.HasMany(x => x.CistkaAppointments).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
			builder.HasMany(x => x.PirsinqAppointments).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
			builder.HasMany(x => x.LipuckaAppointments).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
			builder.HasMany(x => x.HairCutAppointments).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
			builder.HasMany(x => x.MakeUpAppointments).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
			builder.HasMany(x => x.CistkaAppointments).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
			builder.HasMany(x => x.OutMoney).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
			builder.HasMany(x => x.Incomes).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
			builder.HasMany(x => x.Stocks).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);



		}
	}
}
