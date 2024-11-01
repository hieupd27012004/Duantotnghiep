using AppData.Model;
using AppData;
using AppAPI.IRepository;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Repository
{
    public class SanPhamChiTietRepo : ISanPhamChiTietRepo
    {
        private readonly AppDbcontext _context;

        public SanPhamChiTietRepo(AppDbcontext context)
        {
            _context = context;
        }

        public bool Create(SanPhamChiTiet sanPhamChitiet)
        {
            try
            {
                _context.sanPhamChiTiets.Add(sanPhamChitiet);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            var hinhAnhs =  _context.hinhAnh.Where(h => h.IdSanPhamChiTiet == id).ToList();

            // Xóa tất cả hình ảnh liên quan
            _context.hinhAnh.RemoveRange(hinhAnhs);

            // Xóa sản phẩm chi tiết
            var sanPhamChiTiet =  _context.sanPhamChiTiets.Find(id);
            if (sanPhamChiTiet != null)
            {
                _context.sanPhamChiTiets.Remove(sanPhamChiTiet);
                 _context.SaveChangesAsync();
                return true;
            }

            return false; // Không tìm thấy sản phẩm chi tiết
        }

        public SanPhamChiTiet GetSanPhamChitietById(Guid id)
        {
            var sanPhamChitiet = _context.sanPhamChiTiets.Find(id);
            return sanPhamChitiet;
        }

        public List<SanPhamChiTiet> GetSanPhamChiTiet()
        {
            var list = _context.sanPhamChiTiets.ToList();
            return list;
        }
        public bool Update(SanPhamChiTiet sanPhamChitiet)
        {
            var sanPhamChitietUpdate = _context.sanPhamChiTiets.Find(sanPhamChitiet.IdSanPhamChiTiet);
            if (sanPhamChitietUpdate != null)
            {
                sanPhamChitietUpdate.Gia = sanPhamChitiet.Gia;
                sanPhamChitietUpdate.SoLuong = sanPhamChitiet.SoLuong;
                sanPhamChitietUpdate.NgayCapNhat = sanPhamChitiet.NgayCapNhat;
                sanPhamChitietUpdate.NgayTao = sanPhamChitiet.NgayTao;
                sanPhamChitietUpdate.NguoiCapNhat = sanPhamChitiet.NguoiCapNhat;
                sanPhamChitietUpdate.NguoiTao = sanPhamChitiet.NguoiTao;
                //sanPhamChitietUpdate.KichHoat = sanPhamChitiet.KichHoat == 1 ? 1 : 0;
                sanPhamChitietUpdate.XuatXu = sanPhamChitiet.XuatXu;
                _context.sanPhamChiTiets.Update(sanPhamChitietUpdate);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<List<SanPhamChiTiet>> GetSanPhamChiTietBySanPhamId(Guid sanPhamId)
        {
            return await _context.sanPhamChiTiets              
                 .Where(s => s.IdSanPham == sanPhamId)
                 .ToListAsync();
        }

    }
}
