using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class ChucVu
	{
		[Key]
		public Guid IdChucVu { get; set; }

		public string Code { get; set; }
		public string TenChucVu { get; set; }
	}
}
