namespace EFTurtorial.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHoc")]
    public partial class LopHoc
    {
        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual List<SinhVien> SinhViens { get; set; }
    }
}
