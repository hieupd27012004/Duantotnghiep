using AppAPI.IRepository;
using AppData.Model;
using AppData;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Repository
{
    public class SanPhamRepo : ISanPhamRepo
    {
        private readonly AppDbcontext _context;

        public SanPhamRepo(AppDbcontext context)
        {
            _context = context;
        }

        public bool Create(SanPham sanPham)
        {
            try
            {
                _context.sanPhams.Add(sanPham);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                var sanPham = _context.sanPhams.Find(id);
                if (sanPham != null)
                {
                    _context.sanPhams.Remove(sanPham);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public SanPham GetSanPhamById(Guid id)
        {
            var sanPham = _context.sanPhams.Find(id);
            return sanPham;
        }

        public List<SanPham> GetSanPham(string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return _context.sanPhams
                    .AsNoTracking()
                    .Include(sp => sp.SanPhamChiTiets)
                        .ThenInclude(spc => spc.KichCo) // Include KichCo
                    .Include(sp => sp.SanPhamChiTiets)
                        .ThenInclude(spc => spc.MauSac) // Include MauSac
                    .Include(sp => sp.SanPhamChiTiets)
                        .ThenInclude(spc => spc.DayGiay) // Include DayGiay
                                            .Include(sp => sp.SanPhamChiTiets)
                        .ThenInclude(spc => spc.SoLuong)
                    .Include(sp => sp.ChatLieu)
                    .Include(sp => sp.KieuDang)
                    .Include(sp => sp.ThuongHieu)
                    .Include(sp => sp.DanhMuc)
                    .Include(sp => sp.DeGiay)
                    .Where(sp => sp.KichHoat == 1) // Lọc sản phẩm đã kích hoạt
                    .ToList();
            }
            else
            {
                return _context.sanPhams
                    .AsNoTracking()
                    .Include(sp => sp.SanPhamChiTiets)
                        .ThenInclude(spc => spc.KichCo) // Include KichCo
                    .Include(sp => sp.SanPhamChiTiets)
                        .ThenInclude(spc => spc.MauSac) // Include MauSac
                    .Include(sp => sp.SanPhamChiTiets)
                        .ThenInclude(spc => spc.DayGiay) // Include DayGiay
                    .Include(sp => sp.ChatLieu)
                    .Include(sp => sp.KieuDang)
                    .Include(sp => sp.ThuongHieu)
                    .Include(sp => sp.DanhMuc)
                    .Include(sp => sp.DeGiay)
                    .Where(s => s.TenSanPham.Contains(name) && s.KichHoat == 1) // Lọc sản phẩm đã kích hoạt và tên sản phẩm chứa từ khóa
                    .ToList();
            }
        }

        public bool Update(SanPham sanPham)
        {
            var sanPhamUpdate = _context.sanPhams.Find(sanPham.IdSanPham);
            if (sanPhamUpdate != null)
            {
                sanPhamUpdate.TenSanPham = sanPham.TenSanPham;
                sanPhamUpdate.NgayCapNhat = sanPham.NgayCapNhat;
                sanPhamUpdate.NgayTao = sanPham.NgayTao;
                sanPhamUpdate.NguoiCapNhat = sanPham.NguoiCapNhat;
                sanPhamUpdate.NguoiTao = sanPham.NguoiTao;
                sanPhamUpdate.KichHoat = sanPham.KichHoat == 1 ? 1 : 0;
                sanPhamUpdate.MoTa = sanPham.MoTa;
                _context.sanPhams.Update(sanPhamUpdate);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
