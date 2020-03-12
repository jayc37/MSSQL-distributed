namespace bai2.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [Required]
        [StringLength(20)]
        public string idnhanvien { get; set; }

        [StringLength(60)]
        public string tennhanvien { get; set; }
        [StringLength(40)]
        public string diachi { get; set; }
        [StringLength(24)]
        public string sodienthoai { get; set; }

        [StringLength(40)]
        public string email { get; set; }

        
        public string luong { get; set; }
        [StringLength(20)]
        public string chucvu { get; set; }
        [StringLength(10)]
        public string gioitinh { get; set; }

        public DateTime ngaysinh { get; set; }

        public DateTime ngaybatdau { get; set; }
        [StringLength(20)]
        public string idbophan { get; set; }
        [StringLength(20)]
        public string quyen { get; set; }
    }
}
