using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class GioHangChiTiet
	{
		public Guid IdGioHangChiTiet { get; set; }
		public int DonGia { get; set; }
		public int SoLuong { get; set; }
		public int TongTien { get; set; }
		public int KichHoat { get; set; }
		public virtual GioHang GioHang { get; set; }
		public virtual SanPhamChiTiet SanPhamChiTiet { get; set; }
	}
}
