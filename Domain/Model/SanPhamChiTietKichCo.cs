using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
    public class SanPhamChiTietKichCo
    {
        public Guid IdSanPhamChiTiet { get; set; }  // Khóa ngoại đến SanPhamChiTiet
        public Guid IdKichCo { get; set; }           // Khóa ngoại đến KichCo

        public virtual SanPhamChiTiet? SanPhamChiTiet { get; set; }
        public virtual KichCo? KichCo { get; set; }
    }
}
