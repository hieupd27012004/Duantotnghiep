﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class ThuongHieu
	{
		[Required(ErrorMessage = "Không Được Để Trống")]
		public Guid IdThuongHieu { get; set; }
		[Required(ErrorMessage = "Không Được Để Trống")]
		public string TenThuongHieu { get; set; }
		[Required(ErrorMessage = "Không Được Để Trống")]
		[RegularExpression(@"^(\+84|0)[3|5|7|8|9][0-9]{8}$", ErrorMessage = "Không Đúng Định Dạng")]
		[StringLength(10, MinimumLength = 10, ErrorMessage = "Phải Đủ 10 Số")]
		public DateTime NgayCapNhat { get; set; }
		[Required(ErrorMessage = "Không Được Để Trống")]
		[RegularExpression(@"^(\+84|0)[3|5|7|8|9][0-9]{8}$", ErrorMessage = "Không Đúng Định Dạng")]
		[StringLength(10, MinimumLength = 10, ErrorMessage = "Phải Đủ 10 Số")]
		public DateTime NgayTao { get; set; }
		[Required(ErrorMessage = "Không Được Để Trống")]
		public string NguoiCapNhat { get; set; }
		[Required(ErrorMessage = "Không Được Để Trống")]
		public string NguoiTao { get; set; }
		public int KichHoat { get; set; }

		public virtual ICollection<SanPham>? SanPhams { get; set; }
	}
}
