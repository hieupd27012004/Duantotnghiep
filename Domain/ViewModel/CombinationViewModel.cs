using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.ViewModel
{
    public class CombinationViewModel
    {
        public string? TenSanPham { get; set; } // Add this property
        public string? KichCo { get; set; }
        public string? MauSac { get; set; }
        public double? Gia { get; set; }
        public double? SoLuong { get; set; }
        public string? XuatXu { get; set; }
        public Guid IdSanPhamChiTiet { get; set; }
    }
}
