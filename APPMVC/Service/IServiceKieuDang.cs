using AppData.Model;

namespace APPMVC.Service
{
    public interface IServiceKieuDang
    {
        Task<List<KieuDang>> GetKieuDang();
        Task<KieuDang> GetKieuDangById(Guid id);
        Task Create(KieuDang kieuDang);
        Task Update(KieuDang kieuDang);
        Task Delete(Guid id);
    }
}
