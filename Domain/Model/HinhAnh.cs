using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class HinhAnh
	{
		public Guid IdHinhAnh { get; set; }

		public string TenAnh { get; set; }

		public string HienThi { get; set; }

		public string LaAnhChinh { get; set; }

		public virtual SanPham SanPham { get; set; }

		public virtual MauSac MauSac { get; set; }
	}
}
