namespace WebApplication2.Models.CSDL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tour")]
    public partial class Tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tour()
        {
            BangGias = new HashSet<BangGia>();
            CTDatTours = new HashSet<CTDatTour>();
            CTHoaDons = new HashSet<CTHoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string MaTour { get; set; }

        [StringLength(50)]
        public string TenTour { get; set; }

        [StringLength(100)]
        public string DiaChiTour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKhoiHanh { get; set; }

        public int? Gia { get; set; }

        [StringLength(50)]
        public string Anh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BangGia> BangGias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDatTour> CTDatTours { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHoaDon> CTHoaDons { get; set; }
    }
}
