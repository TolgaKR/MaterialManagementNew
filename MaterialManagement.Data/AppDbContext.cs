using MaterialManagement.Entity;
using MaterialManagement.Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace MaterialManagement.Data
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        // Constructor, veritabanı bağlantısı için gerekli seçenekleri alır
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Fiyat> Fiyatlar { get; set; }
        public DbSet<Malzeme> Malzemeler { get; set; }
        public DbSet<MalzemeGrup> MalzemeGruplari { get; set; }
        public DbSet<ReceteBaslik> ReceteBasliklar { get; set; }
        public DbSet<ReceteKalem> ReceteKalemler { get; set; }
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<UrunTipiTablosu> UrunTipiTablolari { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // IdentityDbContext'in varsayılan yapılandırmasını ekler
            base.OnModelCreating(modelBuilder);

            // Fiyat Tablosu
            modelBuilder.Entity<Fiyat>(entity =>
            {
                entity.Property(f => f.BaslangicTarihi).IsRequired();
                entity.Property(f => f.BitisTarihi).IsRequired();
                entity.Property(f => f.Aktif).IsRequired();
            });

            // Malzeme Tablosu
            modelBuilder.Entity<Malzeme>(entity =>
            {
                entity.Property(m => m.MalzemeAdi).IsRequired().HasMaxLength(100);
                entity.Property(m => m.StokMiktari).IsRequired();
                entity.Property(m => m.Birim).IsRequired();
                entity.Property(m => m.Price).IsRequired();
            });

            // ReceteBaslik Tablosu
            modelBuilder.Entity<ReceteBaslik>(entity =>
            {
                entity.Property(r => r.VersiyonNo).HasMaxLength(50).IsRequired();
                entity.Property(r => r.OlusturulmaTarihi).IsRequired();
            });

            // ReceteKalem Tablosu
            modelBuilder.Entity<ReceteKalem>(entity =>
            {
                entity.Property(k => k.Miktar).IsRequired();
                entity.Property(k => k.Birim).IsRequired();
            });

            // Stok Tablosu
            modelBuilder.Entity<Stok>(entity =>
            {
                entity.Property(s => s.Miktar).IsRequired();
                entity.Property(s => s.IslemTipi).IsRequired();
                entity.Property(s => s.Tarih).IsRequired();
            });
        }



    }
}


