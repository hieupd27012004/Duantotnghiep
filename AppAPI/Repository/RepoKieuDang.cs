using AppData;
using AppData.Model;

namespace AppAPI.Repository
{
    public class RepoKieuDang : IRepoKieuDang
    {
        AppDbcontext _context;
        public RepoKieuDang()
        {
            _context = new AppDbcontext();
        }
        public bool Create(KieuDang kieuDang)
        {
            try
            {
                if (kieuDang.IdKieuDang == Guid.Empty)
                {
                    kieuDang.IdKieuDang = Guid.NewGuid();
                }

                kieuDang.NgayTao = DateTime.Now;
                kieuDang.NgayCapNhat = DateTime.Now;

                if (string.IsNullOrEmpty(kieuDang.NguoiTao))
                {
                    kieuDang.NguoiTao = "System"; //Sau khi xong login sẽ auto hiển thị tên người tạo ở đây
                }

                if (kieuDang.KichHoat == 0)
                {
                    kieuDang.KichHoat = 1;
                }

                _context.kieuDangs.Add(kieuDang);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tạo KieuDang: {ex.Message}");
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                var kieuDang = _context.kieuDangs.Find(id);
                if(kieuDang != null)
                {
                    _context.kieuDangs.Remove(kieuDang);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public KieuDang GetKieuDangById(Guid id)
        {
            var kieuDang = _context.kieuDangs.Find(id);
            return kieuDang;
        }

        public List<KieuDang> GetKieuDang()
        {
            return _context.kieuDangs.ToList();
        }


        public bool Update(KieuDang kieuDang)
        {
            var kieuDangUpdate = _context.kieuDangs.Find(kieuDang.IdKieuDang);
            if (kieuDangUpdate != null)
            {
                kieuDangUpdate.TenKieuDang = kieuDang.TenKieuDang;
                kieuDangUpdate.NgayCapNhat = kieuDang.NgayCapNhat;
                kieuDangUpdate.NgayTao = kieuDang.NgayTao;
                kieuDangUpdate.NguoiTao = kieuDang.NguoiTao;
                kieuDangUpdate.KichHoat = kieuDang.KichHoat;
                _context.kieuDangs.Update(kieuDangUpdate);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
