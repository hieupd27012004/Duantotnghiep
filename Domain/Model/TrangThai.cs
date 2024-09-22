using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class TrangThai
	{
		[Required(ErrorMessage = "Không Được Để Trống")]
		public Guid IdTrangThai { get; set; }
		[Required(ErrorMessage = "Không Được Để Trống")]
		public string TenTrangThai { get; set; }

		public virtual ICollection<GiaoDich> GiaoDich { get; set; }
		public virtual ICollection<HoaDon> HoaDons { get; set; }
	}
}
