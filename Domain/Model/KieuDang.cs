using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class KieuDang
	{
		public Guid IdKieuDang { get; set; }
		public string TenKieuDang { get; set; }
		public DateTime NgayCapNhat { get; set; }
		public DateTime NgayTao { get; set; }
		public string NguoiTao { get; set; }
		public int KichHoat { get; set; }
	}
}
