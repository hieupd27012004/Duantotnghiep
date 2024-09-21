using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class DiaChi
	{
		public Guid IdDiaChi { get; set; }
		public string HoTen { get; set; }
		public string SoDienThoai { get; set; }
		public string DiaChi1 { get; set; }
		public string DiaChiMacDinh { get; set; }
		public DateTime NgayTao { get; set; }
		public DateTime NgayCapNhat { get; set; }
		public Guid IdKhachHang { get; set; }
	}
}
