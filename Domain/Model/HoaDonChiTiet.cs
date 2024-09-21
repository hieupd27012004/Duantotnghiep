using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class HoaDonChiTiet
	{
		public Guid IdHoaDonChiTiet { get; set; }
		public int DonGia { get; set; }
		public int SoLuong { get; set; }
		public int TongTien { get; set; }
		public int KichHoat { get; set; }
		public virtual HoaDon HoaDon { get; set; }
		public virtual SanPhamChiTiet SanPhamChiTiet { get; set; }
	}
}
