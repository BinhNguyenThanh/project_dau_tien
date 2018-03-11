namespace WebApplication2.Models.CSDL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHoaDon")]
    public partial class CTHoaDon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaTour { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaHD { get; set; }

        public int? SoLuongNguoiLon { get; set; }

        public int? SoLuongTreEm { get; set; }

        public int? SoLuongTreNho { get; set; }

        public int? TongCong { get; set; }

        public int? ThanhTien { get; set; }

        [StringLength(100)]
        public string HinhThucThanhToan { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
