using AppData.Model;

namespace AppAPI.Service
{
    public interface IServiceKieuDang
    {
        List<KieuDang> GetKieuDang();
        KieuDang GetKieuDangById(Guid id);
        bool Create(KieuDang kieuDang);
        bool Update(KieuDang kieuDang);
        bool Delete(Guid id);
    }
}
