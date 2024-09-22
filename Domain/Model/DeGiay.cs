using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class DeGiay
	{
		public Guid IdDeGiay { get; set; }
		public string TenDeGiay { get; set; }
		public DateTime NgayCapNhat { get; set; }
		public DateTime NgayTao { get; set; }
		public string NguoiCapNhat { get; set; }
		public string NguoiTao { get; set; }
		public int KichHoat { get; set; }

		public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
	}
}
