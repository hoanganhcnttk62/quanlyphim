//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ontap
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public Nullable<System.DateTime> NgayVaoLam { get; set; }
    
        public virtual NhanVienBanHang NhanVienBanHang { get; set; }
        public virtual NhanVienGiaoNhan NhanVienGiaoNhan { get; set; }
    }
}
