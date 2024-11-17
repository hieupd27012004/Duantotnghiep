using AppAPI.IRepository;
using AppData;
using AppData.Model;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Repository
{
    public class DiaChiRepo : IDiaChiRepo
    {
        private readonly AppDbcontext _context;
        public DiaChiRepo()
        {
            _context = new AppDbcontext();
        }
        public bool Create(DiaChi diaChi)
        {
            try
            {
                _context.diaChi.Add(diaChi);
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
                var getId = _context.diaChi.Find(id);
                if (getId != null)
                {
                    _context.diaChi.Remove(getId);
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

        public List<DiaChi> GetDiaChi(string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return _context.diaChi.ToList();
            }
            else
            {
                return _context.diaChi.Where(d => d.HoTen.Contains(name)).ToList();
            }
        }

        public DiaChi GetDiaChiById(Guid id)
        {
            var DcId = _context.diaChi.Find(id);
            return DcId;
        }

        public bool Update(DiaChi diaChi)
        {
            var diaChiUpdate = _context.diaChi.Find(diaChi.IdDiaChi);
            if(diaChiUpdate != null)
            {
                diaChiUpdate.HoTen = diaChi.HoTen;
                diaChiUpdate.SoDienThoai = diaChi.SoDienThoai;
                diaChiUpdate.DiaChiMacDinh = diaChi.DiaChiMacDinh;
                diaChiUpdate.NgayTao = diaChi.NgayTao;
                diaChiUpdate.NgayCapNhat = diaChi.NgayCapNhat;
                diaChiUpdate.IdKhachHang = diaChi.IdKhachHang;
                _context.diaChi.Update(diaChiUpdate);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public async Task<List<DiaChi>> GetDiaChiByIdKH(Guid idKH)
        {
            return await _context.diaChi.Where(dc => dc.IdKhachHang == idKH).ToListAsync();
        }
        public bool UpdateDCbyIdKH(Guid id, DiaChi dc)
        {
            try
            {
                var diaChiUpdate = _context.diaChi.FirstOrDefault(d => d.IdKhachHang == id && d.IdDiaChi == dc.IdDiaChi);

                if (diaChiUpdate != null)
                {
                    diaChiUpdate.HoTen = dc.HoTen;
                    diaChiUpdate.SoDienThoai = dc.SoDienThoai;
                    diaChiUpdate.DiaChiMacDinh = dc.DiaChiMacDinh;
                    diaChiUpdate.NgayTao = dc.NgayTao;
                    diaChiUpdate.NgayCapNhat = DateTime.Now;

                    _context.diaChi.Update(diaChiUpdate);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    // Log hoặc Debug message nếu không tìm thấy địa chỉ
                    Console.WriteLine("Không tìm thấy địa chỉ để cập nhật.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật địa chỉ: {ex.Message}");
                return false;
            }
        }
    }
}
