using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class LichSuHoaDon
	{
		public Guid IdLichSuHoaDon { get; set; }
		public string ThaoTac { get; set; }
		public DateTime NgayTao { get; set; }
		public string NguoiThaoTac { get; set; }
		public string TrangThai { get; set; }
		public Guid IdHoaDon { get; set; }
		public virtual HoaDon HoaDon { get; set; }
	}
}
