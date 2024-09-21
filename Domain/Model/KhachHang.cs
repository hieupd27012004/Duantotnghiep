using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class KhachHang
	{
		public Guid IdKhachHang { get; set; }
		public string HoTen { get; set; }
		public string SoDienThoai { get; set; }
		public string Email { get; set; }
		public string AuthProvider { get; set; }
		public string MatKhau { get; set; }
		public DateTime NgayTao { get; set; }
		public DateTime NgayCapNhat { get; set; }
		public string NguoiTao { get; set; }
		public string NguoiCapNhat { get; set; }
		public int KichHoat { get; set; }
	}
}
