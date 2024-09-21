using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class NhanVien
	{
		[Key]
		public Guid IdNhanVien { get; set; }
		public string TenNhanVien { get; set; }
		public string SoDienThoai { get; set; }
		public string Email { get; set; }
		public byte AnhNhanVien { get; set; }
		public string MatKhau { get; set; }
		public string AuthProvider { get; set; }
		public string DiaChi { get; set; }
		public DateTime NgayCapNhat { get; set; }
		public DateTime NgayTao { get; set; }
		public string NguoiTao { get; set; }
		public string NguoiCapNhat { get; set; }
		public int KichHoat { get; set; }
		public int TrangThai { get; set; }
		public ChucVu chucVu { get; set; }
	}
}
