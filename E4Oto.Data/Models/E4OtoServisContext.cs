using System;
using System.Data.SqlClient;
using E4Oto.Crypt;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace E4Oto.Data.Models
{
   
    public partial class E4OtoServisContext : DbContext
    {
        public E4OtoServisContext()
        {
        }

        public E4OtoServisContext(DbContextOptions<E4OtoServisContext> options)
            : base(options)
        {
           
        }

        public virtual DbSet<AramaDetaylari> AramaDetaylaris { get; set; }
        public virtual DbSet<Aramalar> Aramalars { get; set; }
        public virtual DbSet<Danismanlar> Danismanlars { get; set; }
        public virtual DbSet<DosyaDurumlari> DosyaDurumlaris { get; set; }
        public virtual DbSet<MusteriAraclari> MusteriAraclaris { get; set; }
        public virtual DbSet<Musteriler> Musterilers { get; set; }
        public virtual DbSet<Operatorler> Operatorlers { get; set; }
        public virtual DbSet<RandevuSebepleri> RandevuSebepleris { get; set; }
        public virtual DbSet<Randevular> Randevulars { get; set; }
        public virtual DbSet<Sonuclar> Sonuclars { get; set; }
        public virtual DbSet<ViewMain> ViewMains { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                SqlConnectionStringBuilder builder = Reader.GetCnnStr(); 
                optionsBuilder.UseSqlServer(builder.ConnectionString);
            }
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             

            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<AramaDetaylari>(entity =>
            {
                entity.ToTable("AramaDetaylari");

                entity.Property(e => e.RandevuDanismani).HasMaxLength(150);

                entity.Property(e => e.RandevuNedeni).HasColumnType("text");

                entity.Property(e => e.RandevuTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.TeklifHatirlatmaTarihi).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Arama)
                    .WithMany(p => p.AramaDetaylaris)
                    .HasForeignKey(d => d.AramaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AramaDetaylari_Aramalar");

                entity.HasOne(d => d.DosyaDurumuNavigation)
                    .WithMany(p => p.AramaDetaylaris)
                    .HasForeignKey(d => d.DosyaDurumu)
                    .HasConstraintName("FK_AramaDetaylari_DosyaDurumlari");

                entity.HasOne(d => d.SonucNavigation)
                    .WithMany(p => p.AramaDetaylaris)
                    .HasForeignKey(d => d.Sonuc)
                    .HasConstraintName("FK_AramaDetaylari_Sonuclar");
            });

            modelBuilder.Entity<Aramalar>(entity =>
            {
                entity.ToTable("Aramalar");

                entity.Property(e => e.Tarih).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.Aramalars)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_Aramalar_MusteriAraclari");

                entity.HasOne(d => d.Musteri)
                    .WithMany(p => p.Aramalars)
                    .HasForeignKey(d => d.MusteriId)
                    .HasConstraintName("FK_Aramalar_Musteriler");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.Aramalars)
                    .HasForeignKey(d => d.OperatorId)
                    .HasConstraintName("FK_Aramalar_Operatorler");
            });

            modelBuilder.Entity<Danismanlar>(entity =>
            {
                entity.ToTable("Danismanlar");

                entity.Property(e => e.Kodu).HasMaxLength(50);

                entity.Property(e => e.Unvani).HasMaxLength(150);
            });

            modelBuilder.Entity<DosyaDurumlari>(entity =>
            {
                entity.ToTable("DosyaDurumlari");

                entity.Property(e => e.Aktif).HasDefaultValueSql("((1))");

                entity.Property(e => e.Kodu).HasMaxLength(50);

                entity.Property(e => e.Tanimi).HasMaxLength(50);
            });

            modelBuilder.Entity<MusteriAraclari>(entity =>
            {
                entity.ToTable("MusteriAraclari");

                entity.Property(e => e.AracTanimi).HasMaxLength(150);

                entity.Property(e => e.Km).HasColumnType("decimal(5, 1)");

                entity.Property(e => e.Marka).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.MotorNo).HasMaxLength(50);

                entity.Property(e => e.Plaka).HasMaxLength(50);

                entity.Property(e => e.Renk).HasMaxLength(50);

                entity.Property(e => e.SasiNo).HasMaxLength(150);

                entity.Property(e => e.Seri).HasMaxLength(50);

                entity.Property(e => e.SonServisTarihi).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Musteri)
                    .WithMany(p => p.MusteriAraclaris)
                    .HasForeignKey(d => d.MusteriId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MusteriAraclari_Musteriler");
            });

            modelBuilder.Entity<Musteriler>(entity =>
            {
                entity.ToTable("Musteriler");

                entity.Property(e => e.Adres1).HasMaxLength(150);

                entity.Property(e => e.Adres2).HasMaxLength(150);

                entity.Property(e => e.Adres3).HasMaxLength(150);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Il).HasMaxLength(50);

                entity.Property(e => e.Ilce).HasMaxLength(50);

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.MusteriNo).HasMaxLength(50);

                entity.Property(e => e.Telefon1).HasMaxLength(50);

                entity.Property(e => e.Telefon2).HasMaxLength(50);

                entity.Property(e => e.Telefon3).HasMaxLength(50);

                entity.Property(e => e.Unvani).HasMaxLength(150);
            });

            modelBuilder.Entity<Operatorler>(entity =>
            {
                entity.ToTable("Operatorler");

                entity.Property(e => e.IseGirisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.Kodu).HasMaxLength(50);

                entity.Property(e => e.Unvani).HasMaxLength(150);
            });

            modelBuilder.Entity<RandevuSebepleri>(entity =>
            {
                entity.ToTable("RandevuSebepleri");

                entity.Property(e => e.Aktif).HasDefaultValueSql("((1))");

                entity.Property(e => e.Kodu).HasMaxLength(50);

                entity.Property(e => e.Tanimi).HasMaxLength(50);
            });

            modelBuilder.Entity<Randevular>(entity =>
            {
                entity.ToTable("Randevular");

                entity.Property(e => e.BaslangicTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.BitisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.CarsaIslendiMi).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmsAldiMi).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.Randevulars)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_Randevular_MusteriAraclari");

                entity.HasOne(d => d.Arama)
                    .WithMany(p => p.Randevulars)
                    .HasForeignKey(d => d.AramaId)
                    .HasConstraintName("FK_Randevular_Aramalar");

                entity.HasOne(d => d.Danisman)
                    .WithMany(p => p.Randevulars)
                    .HasForeignKey(d => d.DanismanId)
                    .HasConstraintName("FK_Randevular_Danismanlar");

                entity.HasOne(d => d.Musteri)
                    .WithMany(p => p.Randevulars)
                    .HasForeignKey(d => d.MusteriId)
                    .HasConstraintName("FK_Randevular_Musteriler");
            });

            modelBuilder.Entity<Sonuclar>(entity =>
            {
                entity.ToTable("Sonuclar");

                entity.Property(e => e.Aktif).HasDefaultValueSql("((1))");

                entity.Property(e => e.Kodu).HasMaxLength(50);

                entity.Property(e => e.Tanimi).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewMain>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewMain");

                entity.Property(e => e.MusteriNo).HasMaxLength(50);

                entity.Property(e => e.Unvani).HasMaxLength(150);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
