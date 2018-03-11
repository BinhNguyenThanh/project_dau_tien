namespace WebApplication2.Models.CSDL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTDatTour")]
    public partial class CTDatTour
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaTour { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaDatTour { get; set; }

        public int? SoLuongNguoiLon { get; set; }

        [StringLength(50)]
        public string TenNguoiLon { get; set; }

        public int? SoLuongTreEm { get; set; }

        [StringLength(50)]
        public string TenTreEm { get; set; }

        public int? SoLuongTreNho { get; set; }

        [StringLength(50)]
        public string TenTreNho { get; set; }

        public virtual DatTour DatTour { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
