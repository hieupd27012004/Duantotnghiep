using AppAPI.IRepository;
using AppData;
using AppData.Model;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Repository
{
    public class KhachHangRepo : IKhachHangRepo
    {
        private readonly AppDbcontext _context;
        public KhachHangRepo()
        {
            _context = new AppDbcontext();
        }
        public async Task<KhachHang> CreateKH(KhachHang kh)
        {
            kh.IdKhachHang = Guid.NewGuid();
            kh.AuthProvider = "tạmtrống";
            kh.NgayTao = DateTime.Now;
            kh.NgayCapNhat = DateTime.Now;
            kh.NguoiTao = kh.HoTen;
            kh.NguoiCapNhat = kh.HoTen;
            kh.KichHoat = 1;
            GioHang gioHang = new GioHang() 
            { 
                IdGioHang = Guid.NewGuid(),
                IdKhachHang = kh.IdKhachHang,
                KhachHang = kh,
            };
            kh.GioHang = gioHang;

            _context.khachHangs.Add(kh);
            await _context.SaveChangesAsync();
            return kh;
        }

        public async Task DeleteKH(Guid id)
        {
            var khachHang = await _context.khachHangs.FindAsync(id);
            if(khachHang != null )
            {
                _context.khachHangs.Remove(khachHang);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<KhachHang>> GetAllKhachHang()
        {
            return await _context.khachHangs.ToListAsync();
        }

        public async Task<KhachHang> GetByEmail(string email)
        {
            return await _context.khachHangs.FirstOrDefaultAsync(kh => kh.Email == email);
        }

        public async Task<KhachHang> GetBySDT(string sdT)
        {
            return await _context.khachHangs.FirstOrDefaultAsync(kh => kh.SoDienThoai == sdT);
        }

        public async Task<KhachHang> GetIdKhachHang(Guid id)
        {
            return await _context.khachHangs.FindAsync(id);
        }

        public async Task<KhachHang> UpdateKH(KhachHang kh)
        {
           _context.khachHangs.Update(kh);
            await _context.SaveChangesAsync();
            return kh;
        }
        public async Task<KhachHang?> Login(string email, string password)
        {
            var kh = await _context.khachHangs.FirstOrDefaultAsync(kh => kh.Email == email);
            if (kh == null)
            {
                throw new Exception("Email Không tồn tại");
            }
            //Kiểm tra mk
            if(kh.MatKhau != password)
            {
                throw new Exception("Mật Khẩu Không Chính Xác");
            }
            
            //Hợp lệ trả về kh
            return kh;  
        }
    }
}
