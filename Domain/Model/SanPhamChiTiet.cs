using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class SanPhamChiTiet
	{
		public Guid IdSanPhamChiTiet { get; set; }
		public int Gia { get; set; }
		public int SoLuong { get; set; }
		public string CoHienThi { get; set; }
		public DateTime NgayCapNhat { get; set; }
		public DateTime NgayTao { get; set; }
		public string NguoiCapNhat { get; set; }
		public string NguoiTao { get; set; }
		public int KichHoat { get; set; }
		public Guid IdKichCo { get; set; }
		public Guid IdMauSac { get; set; }
		public Guid IdSanPham { get; set; }
		public Guid IdDayGiay { get; set; }
		public Guid IdDeGiay { get; set; }
		public virtual KichCo KichCo { get; set; }
		public virtual MauSac MauSac { get; set; }
		public virtual SanPham  SanPham { get; set; }
		public virtual DayGiay DayGiay { get; set; }
		public virtual DeGiay DeGiay { get; set; }

		public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }

		public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; }
	}
}
