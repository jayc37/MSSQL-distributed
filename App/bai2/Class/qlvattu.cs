namespace bai2.Class
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class qlvattu : DbContext
    {
        public qlvattu()
            : base("name=qlvattu")
        {
        }

        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<PHIEUXUAT> PHIEUXUATs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.idnhanvien)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.idbophan)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.MAPN)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.MANCC)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.MAKHO)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.MAVT)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUXUAT>()
                .Property(e => e.MAPX)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUXUAT>()
                .Property(e => e.MAKH)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUXUAT>()
                .Property(e => e.MAKHO)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUXUAT>()
                .Property(e => e.MAVT)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUXUAT>()
                .Property(e => e.MANV)
                .IsUnicode(false);
        }
    }
}
