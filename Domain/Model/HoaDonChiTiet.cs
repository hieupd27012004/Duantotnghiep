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
		public Guid IdHoaDon { get; set; }
		public Guid IdSanPhamChiTiet { get; set; }
	}
}
