using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class KhuyenMai
	{
		public Guid IdKhuyenMai { get; set; }
		public string TenKhuyenMai { get; set; }
		public int PhanTramGiam { get; set; }
		public int GiaTriToiDa { get; set; }
		public DateTime NgayCapNhat { get; set; }
		public DateTime NgayTao { get; set; }
		public string NguoiTao { get; set; }
		public string NguoiCapNhat { get; set; }
		public DateTime NgayBatDau { get; set; }
		public DateTime NgayKetThuc { get; set; }
		public string TrangThai { get; set; }
		public int KichHoat { get; set; }
	}
}
