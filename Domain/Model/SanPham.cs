using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class SanPham
	{
		public Guid IdSanPham { get; set; }
		public string TenSanPham { get; set; }
		public DateTime NgayCapNhat { get; set; }
		public DateTime NgayTao { get; set; }
		public string NguoiCapNhat { get; set; }
		public string NguoiTao { get; set; }
		public int KichHoat { get; set; }
		public string MoTa { get; set; }
		public int Sale { get; set; }
		public Guid IdChatLieu { get; set; }
		public Guid IdKieuDang { get; set; }
		public Guid IdThuongHieu { get; set; }
		public Guid IdDanhMuc { get; set; }

		public virtual ChatLieu ChatLieu { get; set; }
		public virtual KieuDang KieuDang { get; set; }
		public virtual ThuongHieu ThuongHieu { get; set; }
		public virtual DanhMuc DanhMuc { get; set; }

		public virtual ICollection<HinhAnh> HinhAnhs { get; set; }
		public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }


	}
}
