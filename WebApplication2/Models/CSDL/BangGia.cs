namespace WebApplication2.Models.CSDL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BangGia")]
    public partial class BangGia
    {
        [Key]
        [StringLength(10)]
        public string MaGiaTour { get; set; }

        [StringLength(10)]
        public string MaTour { get; set; }

        public int? GiaChinh { get; set; }

        public int? GiaNguoiLon { get; set; }

        public int? GiaTreEm { get; set; }

        public int? GiaTreNho { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
