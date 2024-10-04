using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class HinhAnh
	{
		[Required(ErrorMessage = "Không Được Để Trống")]
		public Guid IdHinhAnh { get; set; }

		[Required(ErrorMessage = "Không Được Để Trống")]

		public string TenAnh { get; set; }
		[Required(ErrorMessage = "Không Được Để Trống")]
		public string HienThi { get; set; }
		[Required(ErrorMessage = "Không Được Để Trống")]

		public string LaAnhChinh { get; set; }

		public Guid IdSanPham { get; set; }

		public Guid IdMauSac { get; set; }

		public virtual SanPham? SanPham { get; set; }

		public virtual MauSac? MauSac { get; set; }


	}
}
