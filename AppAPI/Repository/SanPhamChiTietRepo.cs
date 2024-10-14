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
            try
            {
                var sanPhamChitiet = _context.sanPhamChiTiets.Find(id);
                if (sanPhamChitiet != null)
                {
                    _context.sanPhamChiTiets.Remove(sanPhamChitiet);
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
                sanPhamChitietUpdate.Gia = sanPhamChitietUpdate.Gia;
                sanPhamChitietUpdate.SoLuong = sanPhamChitietUpdate.SoLuong;
                sanPhamChitietUpdate.NgayCapNhat = sanPhamChitiet.NgayCapNhat;
                sanPhamChitietUpdate.NgayTao = sanPhamChitiet.NgayTao;
                sanPhamChitietUpdate.NguoiCapNhat = sanPhamChitiet.NguoiCapNhat;
                sanPhamChitietUpdate.NguoiTao = sanPhamChitiet.NguoiTao;
                sanPhamChitietUpdate.KichHoat = sanPhamChitiet.KichHoat == 1 ? 1 : 0;
                _context.sanPhamChiTiets.Update(sanPhamChitietUpdate);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
