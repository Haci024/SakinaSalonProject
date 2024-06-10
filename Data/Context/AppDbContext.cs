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
            optionsBuilder.UseSqlServer("server=Odissey;initial catalog=SakinaSalonDatabase1;integrated Security=true;TrustServerCertificate=true;");

        }
        public DbSet<Filial> Filials { get; set; }

        public DbSet<Master> Masters { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<MasterPosition> MasterPositions { get; set; }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<CosmetologyCategory> CosmetologyCategories { get; set; }

        public DbSet<CosmetologyReport> CosmetologyReports { get; set; }

        public DbSet<HairCutItems> HairCutItems { get; set; }

        public DbSet<HairCutCategoryReports> HairCutCategoryReports { get; set; }

        public DbSet<HairCutCategory> HairCutCategories { get; set; }

        public DbSet<LipuckaReports> LipuckaReports { get; set; }

        public DbSet<PirsinqCategory> PirsinqCategories { get; set; }

        public DbSet<PirsinqReports> PirsinqReports { get; set; }

        public DbSet<LipuckaCategories> LipuckaCategories { get; set; }

        public DbSet<BodyShapingPackets> BodyShapingPackets { get; set; }

        public DbSet<BodyShapingSessionList> BodyShapingSessionLists { get; set; }

        public DbSet<LazerAppointmentReports> LazerAppointmentReports { get; set; }

        public DbSet<LazerCategory> LazerCategories { get; set; }

        public DbSet<MakeUpCategory> MakeUpCategories { get; set; }

        public DbSet<LazerAppointment> LazersAppointment { get; set; }

        public DbSet<CosmetologyAppointment> CosmetologyAppointment { get; set; }

        public DbSet<BodyshapingAppointment> BodyshapingAppointment { get; set; }

        public DbSet<CistkaAppointment> CistkaAppointment { get; set; }

        public DbSet<PirsinqAppointment> PirsinqAppointment { get; set; }

        public DbSet<HairCutAppointment> HairCutAppointment { get; set; }

        public DbSet<LipuckaAppointment> LipuckaAppointment { get; set; }

        public DbSet<MakeUpAppointment> MakeUpAppointment { get; set; }

        public DbSet<SolariumAppointment> SolariumAppointment { get; set; }

        public DbSet<MasterFilial> MasterFilials { get; set; }

        public DbSet<CistkaCategory> CistkaCategories { get; set; }

        public DbSet<KassaActionCategory> KassaActionCategories { get; set; }

        public DbSet<Entity.Concrete.KassaActionList> KassaActionList { get; set; }

        public DbSet<Income> Incomes { get; set; }

        public DbSet<OutMoney> OutMoneys { get; set; }  

        public DbSet<SpendCategory> SpendCategories { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<SolariumUsingList> SolariumUsingLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new MasterConfig());
           modelBuilder.ApplyConfiguration(new LazerCategoryConfig());  
           modelBuilder.ApplyConfiguration(new MasterFilialConfig());   
        }
    }
}
