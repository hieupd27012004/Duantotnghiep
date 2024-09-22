using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class DiaChi
	{
		[Required(ErrorMessage = "Không Được Để Trống")]
		public Guid IdDiaChi { get; set; }
		[Required(ErrorMessage = "Không Được Để Trống")]
		public string HoTen { get; set; }
		[Required(ErrorMessage = "Không Được Để Trống")]
		[RegularExpression(@"^(\+84|0)[3|5|7|8|9][0-9]{8}$", ErrorMessage = "Không Đúng Định Dạng")]
		[StringLength(10, MinimumLength = 10, ErrorMessage = "Phải Đủ 10 Số")]
		public string SoDienThoai { get; set; }
		[Required(ErrorMessage = "Không Được Để Trống")]
		public string Diachi { get; set; }
		[Required(ErrorMessage = "Không Được Để Trống")]
		public string DiaChiMacDinh { get; set; }
		[DataType(DataType.DateTime, ErrorMessage = "Không Đúng Định Dạng")]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		//[Range(typeof(DateTime), "1/1/2020", "12/31/2025", ErrorMessage = "Không Trong Thời Gian Cho Phép")]
		public DateTime NgayTao { get; set; }
		[DataType(DataType.DateTime, ErrorMessage = "Không Đúng Định Dạng")]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		//[Range(typeof(DateTime), "1/1/2020", "12/31/2025", ErrorMessage = "Không Trong Thời Gian Cho Phép")]
		public DateTime NgayCapNhat { get; set; }

		public Guid IdKhachHang { get; set; }
		public virtual KhachHang khachHang { get; set; }
	}
}
