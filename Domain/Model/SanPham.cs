using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class SanPham
	{
		public int IdSanPham { get; set; }
		public string TenSanPham { get; set; }
		public DateTime NgayCapNhat { get; set; }
		public DateTime NgayTao { get; set; }
		public string NguoiCapNhat { get; set; }
		public string NguoiTao { get; set; }
		public int KichHoat { get; set; }
		public string MoTa { get; set; }
		public Guid IdChatLieu { get; set; }
		public Guid IdKieuDang { get; set; }
		public Guid IdThuongHieu { get; set; }
		public Guid IdDanhMuc { get; set; }
		public int Sale { get; set; }
	}
}
