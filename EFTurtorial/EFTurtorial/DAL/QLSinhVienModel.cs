using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EFTurtorial.DAL
{
    public partial class QLSinhVienModel : DbContext
    {
        public QLSinhVienModel()
            : base("name=QLSinhVienModelApp")
        {
        }

        public virtual DbSet<LopHoc> LopHoc { get; set; }
        public virtual DbSet<SinhVien> SinhVien { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SinhVien>()
                .Property(e => e.IDStudent)
                .IsUnicode(false);
        }
    }
}
