using AppData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.ViewModel
{
    public class GioHangChiTietViewModel
    {
        public Guid IdGioHangChiTiet { get; set; }
        public SanPham SanPham { get; set; }
        public List<HinhAnh>? HinhAnhs { get; set; }
        public string TenSanPham { get; set; }
        public double DonGia { get; set; }
        public double SoLuong { get; set; }
        public double TongTien { get; set; }
    }
}
