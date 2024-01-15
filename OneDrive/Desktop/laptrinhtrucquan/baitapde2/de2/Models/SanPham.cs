//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace de2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.SPTheoMaus = new HashSet<SPTheoMau>();
        }
    
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MaPhanLoai { get; set; }
        public Nullable<decimal> GiaNhap { get; set; }
        public Nullable<decimal> DonGiaBanNhoNhat { get; set; }
        public Nullable<decimal> DonGiaBanLonNhat { get; set; }
        public string TrangThai { get; set; }
        public string MoTaNgan { get; set; }
        public string AnhDaiDien { get; set; }
        public string NoiBat { get; set; }
        public string MaPhanLoaiPhu { get; set; }
        public string Maphanloaisuac { get; set; }
        public string Maphanloaisuacp { get; set; }


        public virtual PhanLoai PhanLoai { get; set; }
        public virtual PhanLoaiPhu PhanLoaiPhu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPTheoMau> SPTheoMaus { get; set; }
    }
}