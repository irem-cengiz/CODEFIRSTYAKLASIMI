using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoyaDoyaAnadolu.DATA
{
    public class TurkiyeContex : DbContext
    {
        public DbSet<Sehir> Cities => Set<Sehir>();
        public DbSet<Ozellik> Ozellikler => Set<Ozellik>();

        public object Sehirler { get;  set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENT API İLE MAPPING CONFİGURATION
            //veritabanı ayarları bu override içerisinde yapılır.
            //burada 
            //  modelBuilder.Entity<Sehir>().Property(s=>s.Ad).HasMaxLength(50) = [MaxLength(50)] AYNI ANLAMDA.
            //BU TARZ DÜZENLEMELER BURADAYAPILIR. CİNSİNİN ÖZELLİĞİNİ DÜZENLEDİK.

            //modelBuilder.Entity<Ozellik>().ToTable("Features");
            //yukarıdaki özellikler tablomuzun adını features yapabiliriz. bu gibi düzenlemeler yapılabilir.


            modelBuilder.Entity<Sehir>().HasData(
                new Sehir() { Plaka = 21, Ad = "Diyarbakır" },
                new Sehir() { Plaka = 44, Ad = "Malayta" },
                new Sehir() { Plaka = 38, Ad = "Kayseri" }
                );

            modelBuilder.Entity<Ozellik>().HasData(
                new Ozellik() { Id = 1, Ad = "Karpuz", SehirId = 21 },
                new Ozellik() { Id = 2, Ad = "Kayısı", SehirId = 44 },
                new Ozellik() { Id = 3, Ad = "Mantı", SehirId = 38 },
                new Ozellik() { Id = 4, Ad = "Pastırma", SehirId = 38 }

                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                   @"server=(localdb)\MSSQLLocalDB;database=AnadoluDb;trusted_connection=true");
            //localdb ile bağlandık. 
        }

    }

}
