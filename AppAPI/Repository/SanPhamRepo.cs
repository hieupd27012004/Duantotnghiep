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
                return _context.sanPhams.ToList();
            }
            else
            {
                return _context.sanPhams
                    .Where(m => m.TenSanPham.Contains(name)).ToList();
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
