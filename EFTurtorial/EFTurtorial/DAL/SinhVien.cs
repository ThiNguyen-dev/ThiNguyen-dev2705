namespace EFTurtorial.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        public long ID { get; set; }

        [StringLength(15)]
        public string IDStudent { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(20)]
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        [StringLength(250)]
        public string POB { get; set; }

        public long? IDLop { get; set; }

        [ForeignKey("IDLop")]
        public virtual LopHoc LopHoc { get; set; }
    }
}
