namespace bai2.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUXUAT")]
    public partial class PHIEUXUAT
    {
        [Key]
        [StringLength(5)]
        public string MAPX { get; set; }

        public DateTime NGAYXUAT { get; set; }

        [StringLength(5)]
        public string MAKH { get; set; }

        public string LYDO { get; set; }

        [StringLength(5)]
        public string MAKHO { get; set; }

        [StringLength(5)]
        public string MAVT { get; set; }

        public int SOLUONG { get; set; }

        public int DONGIA { get; set; }

        [StringLength(5)]
        public string MANV { get; set; }

    }
}
