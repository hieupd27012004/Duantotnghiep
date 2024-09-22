using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class TrangThai
	{
		public Guid IdTrangThai { get; set; }
		public string TenTrangThai { get; set; }

		public virtual ICollection<GiaoDich> GiaoDich { get; set; }
		public virtual ICollection<HoaDon> HoaDons { get; set; }
	}
}
