using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class MauSac
	{
		public Guid IdMauSac { get; set; }
		public string TenMauSac { get; set; }
		public DateTime NgayCapNhat { get; set; }
		public DateTime NgayTao { get; set; }
		public string NguoiCapNhat { get; set; }
		public string NguoiTao { get; set; }
		public int KichHoat { get; set; }

		public virtual ICollection<HinhAnh> HinhAnhs { get; set; }

		public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
	}
}
