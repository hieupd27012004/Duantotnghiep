using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class GiaoDich
	{
		public Guid IdGiaoDich { get; set; }
		public string NguoiTao { get; set; }
		public DateTime NgayTao { get; set; }
		public Guid IdHoaDon { get; set; }
		public Guid IdTrangThai { get; set; }
	}
}
