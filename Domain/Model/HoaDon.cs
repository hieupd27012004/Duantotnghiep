using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class HoaDon
	{
		public Guid IdHoaDon { get; set; }
		public string MaDon { get; set; }
		public string NguoiNhan { get; set; }
		public string SoDienThoaiNguoiNhan { get; set; }
		public string DiaChiGiaoHang { get; set; }
		public string LoaiHoaDon { get; set; }
		public string GhiChu { get; set; }
		public int TienShip { get; set; }
		public int TienGiam { get; set; }
		public int TongTienDonHang { get; set; }
		public int TongTienHoaDon { get; set; }
		public DateTime NgayTao { get; set; }
		public string NguoiTao { get; set; }
		public int KichHoat { get; set; }

		public Guid IdKhachHang { get; set; }
		public Guid IdKhuyenMai { get; set; }
		public Guid IdNhanVien { get; set; }
		public Guid IdTrangThai { get; set; }
		public virtual KhachHang KhachHang { get; set; }
		public virtual KhuyenMai KhuyenMai { get; set; }
		public virtual NhanVien NhanVien { get; set; }
		public virtual TrangThai TrangThai { get; set; }

		public virtual ICollection<LichSuHoaDon> LichSuHoaDons { get; set; }
		public virtual ICollection<GiaoDich> GiaoDichs { get; set; }

		public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
	}
}
