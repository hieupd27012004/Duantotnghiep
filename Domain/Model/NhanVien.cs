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
		public string? TenNhanVien { get; set; }
        [RegularExpression(@"^(\+84|0)[3|5|7|8|9][0-9]{8}$", ErrorMessage = "Không Đúng Định Dạng")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Phải Đủ 10 Số")]

        public string? SoDienThoai { get; set; }
		//[Required(ErrorMessage = "Không Được Để Trống")]
		[RegularExpression(@"^[a-zA-Z0-9._%+-]+@gmail\.com$", ErrorMessage = "Không Đúng Định Dạng")]
		public string? Email { get; set; }

		public string? AnhNhanVien { get; set; }
		//[Required(ErrorMessage = "Không Được Để Trống")]
		[StringLength(20, ErrorMessage = "Phải Lớn Hơn 8 Ký tự và Nhỏ hơn 20", MinimumLength = 8)]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Mật khẩu phải chứa ít nhất một chữ cái thường, một chữ cái hoa, một chữ số và một ký tự đặc biệt")]
		public string? MatKhau { get; set; }

		public string? AuthProvider { get; set; }
		//[Required(ErrorMessage = "Không Được Để Trống")]
		public string? DiaChi { get; set; }
		//[DataType(DataType.DateTime, ErrorMessage = "Không Đúng Định Dạng")]
		//[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		//[Range(typeof(DateTime), "1/1/2020", "12/31/2025", ErrorMessage = "Không Trong Thời Gian Cho Phép")]
		public DateTime NgayCapNhat { get; set; }
		//[DataType(DataType.DateTime, ErrorMessage = "Không Đúng Định Dạng")]
		//[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		//[Range(typeof(DateTime), "1/1/2020", "12/31/2025", ErrorMessage = "Không Trong Thời Gian Cho Phép")]
		public DateTime NgayTao { get; set; }

		public string? NguoiTao { get; set; }
		public string? NguoiCapNhat { get; set; }
		public int? KichHoat { get; set; }
		public int? TrangThai { get; set; }

		public Guid? IdchucVu { get; set; }
		public virtual ChucVu? chucVu { get; set; }

		public ICollection<HoaDon>? HoaDons { get; set; }
	}
}
