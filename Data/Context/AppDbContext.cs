using Data.Configs.Db1Configs;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class AppDbContext : IdentityDbContext<AppUser,IdentityRole, string>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			optionsBuilder.UseNpgsql("Host = Odissey; Port = 5432; Database = SakinaSalonDB; User Id = myuser; Password = mypassword");

			//optionsBuilder.UseSqlServer("server=Odissey;initial catalog=SakinaSalonDB;integrated Security=true;TrustServerCertificate=true;");

		}
		/*1*/
		public DbSet<Filial> Filials { get; set; }

      /*2*/ public DbSet<Master> Masters { get; set; }

		/*3*/ public DbSet<Position> Positions { get; set; }

        public DbSet<MasterPosition> MasterPositions { get; set; }/*4*/

		public DbSet<Customers> Customers { get; set; }/*5*/

		public DbSet<CosmetologyCategory> CosmetologyCategories { get; set; }/*6*/

		public DbSet<CosmetologyReport> CosmetologyReports { get; set; }/*7*/

		public DbSet<HairCutItems> HairCutItems { get; set; }/*8*/

		public DbSet<HairCutCategoryReports> HairCutCategoryReports { get; set; }/*9*/

		public DbSet<HairCutCategory> HairCutCategories { get; set; }/*10*/

		public DbSet<LipuckaReports> LipuckaReports { get; set; }/*11*/

		public DbSet<PirsinqCategory> PirsinqCategories { get; set; }/*12*/

		public DbSet<PirsinqReports> PirsinqReports { get; set; }/*13*/

		public DbSet<LipuckaCategories> LipuckaCategories { get; set; }/*14*/

		public DbSet<BodyShapingPackets> BodyShapingPackets { get; set; }/*15*/

		public DbSet<BodyShapingSessionList> BodyShapingSessionLists { get; set; }/*16*/

		public DbSet<LazerAppointmentReports> LazerAppointmentReports { get; set; }/*17*/

		public DbSet<LazerCategory> LazerCategories { get; set; }/*18*/

		public DbSet<MakeUpCategory> MakeUpCategories { get; set; }/*19*/

		public DbSet<LazerAppointment> LazersAppointment { get; set; }/*20*/

		public DbSet<CosmetologyAppointment> CosmetologyAppointment { get; set; }/*21*/

		public DbSet<BodyshapingAppointment> BodyshapingAppointment { get; set; }/*22*/

		public DbSet<CistkaAppointment> CistkaAppointment { get; set; }/*23*/

		public DbSet<PirsinqAppointment> PirsinqAppointment { get; set; }/*24*/

		public DbSet<HairCutAppointment> HairCutAppointment { get; set; }/*25*/

		public DbSet<LipuckaAppointment> LipuckaAppointment { get; set; }/*26*/

		public DbSet<MakeUpAppointment> MakeUpAppointment { get; set; }/*27*/

		public DbSet<SolariumAppointment> SolariumAppointment { get; set; }/*28*/

		public DbSet<MasterFilial> MasterFilials { get; set; }/*29*/

		public DbSet<CistkaCategory> CistkaCategories { get; set; }/*30*/

		public DbSet<KassaActionCategory> KassaActionCategories { get; set; }/*31*/

		public DbSet<KassaActionList> KassaActionList { get; set; }/*32*/

		public DbSet<Income> Incomes { get; set; }/*33*/

		public DbSet<OutMoney> OutMoneys { get; set; }  /*34*/

		public DbSet<SpendCategory> SpendCategories { get; set; }/*35*/

		public DbSet<Stock> Stocks { get; set; }/*36*/

		public DbSet<SolariumUsingList> SolariumUsingLists { get; set; }/*37*/

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new MasterConfig());
            modelBuilder.ApplyConfiguration(new LazerCategoryConfig());  
            modelBuilder.ApplyConfiguration(new MasterFilialConfig());
            modelBuilder.ApplyConfiguration(new BodyShapingAppointmentConfig());
            modelBuilder.ApplyConfiguration(new BodyShapingSessionConfig());
            modelBuilder.ApplyConfiguration(new BodyShapingPacketConfig());
            modelBuilder.ApplyConfiguration(new MasterConfig());
            modelBuilder.ApplyConfiguration(new CosmetologAppointmentConfig());
			modelBuilder.ApplyConfiguration(new CosmetologyCategoryConfig());
			modelBuilder.ApplyConfiguration(new FilialConfig());
            modelBuilder.ApplyConfiguration(new CosmetologyReportConfig());
            modelBuilder.ApplyConfiguration(new HairCutAppointmentConfig());
            modelBuilder.ApplyConfiguration(new IncomeConfig());
            modelBuilder.ApplyConfiguration(new LipuckaAppointmentConfig());
			modelBuilder.ApplyConfiguration(new LipuckaCategoryConfig());
			modelBuilder.ApplyConfiguration(new LipuckaReportsConfig());
			modelBuilder.ApplyConfiguration(new MakeUpAppointmentConfig());
			modelBuilder.ApplyConfiguration(new MakeUpCategoryConfig());
			modelBuilder.ApplyConfiguration(new MakeUpReportsConfig());
			modelBuilder.ApplyConfiguration(new OutMoneyConfig());
			modelBuilder.ApplyConfiguration(new SpendCategoryConfig());
			modelBuilder.ApplyConfiguration(new KassaActionCategoryConfig());
			modelBuilder.ApplyConfiguration(new KassaActionListConfig());
			modelBuilder.ApplyConfiguration(new SolariumSessionListConfig());
			modelBuilder.ApplyConfiguration(new PositionConfig());
			modelBuilder.ApplyConfiguration(new PirsinqAppointmentConfig());
			modelBuilder.ApplyConfiguration(new HairCutCategoryConfig());
			modelBuilder.ApplyConfiguration(new HairCutReportConfig());
			modelBuilder.ApplyConfiguration(new HairCutItemsConfig());
			modelBuilder.ApplyConfiguration(new LazerReportConfig());
			modelBuilder.ApplyConfiguration(new MasterPositionConfig());
			modelBuilder.ApplyConfiguration(new PirsinqReportConfig());
			modelBuilder.ApplyConfiguration(new PirsinqCategoryConfig());
			modelBuilder.ApplyConfiguration(new StockConfig());
            modelBuilder.ApplyConfiguration(new CistkaCategoryConfig());
			modelBuilder.ApplyConfiguration(new CistkaAppointmentConfig());
			modelBuilder.ApplyConfiguration(new CistkaReportConfig());
            modelBuilder.ApplyConfiguration(new AppUserConfig());
			modelBuilder.ApplyConfiguration(new BodySahpingReportsConfig());
			modelBuilder.ApplyConfiguration(new SessionListConfig());

			modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
			{
				entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
			});

			modelBuilder.Entity<IdentityUserRole<string>>(entity =>
			{
				entity.HasKey(e => new { e.UserId, e.RoleId });
			});

			modelBuilder.Entity<IdentityUserToken<string>>(entity =>
			{
				entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
			});


		}
    }
}
