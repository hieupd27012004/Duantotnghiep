using AppData.Model;

namespace APPMVC.IService
{
    public interface IThuongHieuService
    {
        Task<List<ThuongHieu>> GetAllThuongHieu();
        Task<ThuongHieu> GetIdThuongHieu(Guid id);
        Task CreateThuongHieu(ThuongHieu th);
        Task UpdateThuongHieu(ThuongHieu th);
        Task DeleteThuongHieu(Guid id);
    }
}
