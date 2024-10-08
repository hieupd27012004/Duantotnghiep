using AppData.Model;

namespace AppAPI.IService
{
    public interface IKieuDangService
    {
        List<KieuDang> GetKieuDang();
        KieuDang GetKieuDangById(Guid id);
        bool Create(KieuDang kieuDang);
        bool Update(KieuDang kieuDang);
        bool Delete(Guid id);
    }
}
