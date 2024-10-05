using AppData.Model;

namespace AppAPI.Repository
{
    public interface IRepoKieuDang
    {
        List<KieuDang> GetKieuDang();
        KieuDang GetKieuDangById(Guid id);
        bool Create(KieuDang kieuDang);
        bool Update(KieuDang kieuDang);
        bool Delete(Guid id);
    }
}
