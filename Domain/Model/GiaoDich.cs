using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class GiaoDich
	{
		[Required(ErrorMessage = "Không Được Để Trống")]
		public Guid IdGiaoDich { get; set; }
		[Required(ErrorMessage = "Không Được Để Trống")]
		public string NguoiTao { get; set; }

		[DataType(DataType.DateTime, ErrorMessage = "Không Đúng Định Dạng")]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		//[Range(typeof(DateTime), "1/1/2020", "12/31/2025", ErrorMessage = "Không Trong Thời Gian Cho Phép")]
		public DateTime NgayTao { get; set; }
		public Guid IdHoaDon { get; set; }

		public Guid IdTrangThai { get; set; }
		public virtual HoaDon? HoaDon { get; set; }
		public virtual TrangThai? TrangThai { get; set; }
	}
}
