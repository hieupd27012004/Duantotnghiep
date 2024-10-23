using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
    public class SanPhamChiTietMauSac
    {
        public Guid IdSanPhamChiTiet { get; set; }  // Khóa ngoại đến SanPhamChiTiet
        public Guid IdMauSac { get; set; }           // Khóa ngoại đến MauSac

        public virtual SanPhamChiTiet? SanPhamChiTiet { get; set; }
        public virtual MauSac? MauSac { get; set; }
    }
}
