namespace WebApplication2.Models.CSDL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class csdl : DbContext
    {
        public csdl()
            : base("name=csdl")
        {
        }

        public virtual DbSet<BangGia> BangGias { get; set; }
        public virtual DbSet<CTDatTour> CTDatTours { get; set; }
        public virtual DbSet<CTHoaDon> CTHoaDons { get; set; }
        public virtual DbSet<DatTour> DatTours { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BangGia>()
                .Property(e => e.MaGiaTour)
                .IsUnicode(false);

            modelBuilder.Entity<BangGia>()
                .Property(e => e.MaTour)
                .IsUnicode(false);

            modelBuilder.Entity<CTDatTour>()
                .Property(e => e.MaTour)
                .IsUnicode(false);

            modelBuilder.Entity<CTDatTour>()
                .Property(e => e.MaDatTour)
                .IsUnicode(false);

            modelBuilder.Entity<CTHoaDon>()
                .Property(e => e.MaTour)
                .IsUnicode(false);

            modelBuilder.Entity<CTHoaDon>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<DatTour>()
                .Property(e => e.MaDatTour)
                .IsUnicode(false);

            modelBuilder.Entity<DatTour>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<DatTour>()
                .HasMany(e => e.CTDatTours)
                .WithRequired(e => e.DatTour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.CTHoaDons)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<Tour>()
                .Property(e => e.MaTour)
                .IsUnicode(false);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.CTDatTours)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.CTHoaDons)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);
        }
    }
}
