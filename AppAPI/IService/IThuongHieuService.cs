using AppData.Model;

namespace AppAPI.IService
{
    public interface IThuongHieuService
    {
        Task<List<ThuongHieu>> GetAllThuongHieu();
        Task<ThuongHieu> GetIdThuongHieu(Guid id);
        Task<ThuongHieu> CreateTH(ThuongHieu th);
        Task<ThuongHieu> UpdateTH(ThuongHieu th);
        Task DeleteTH(Guid id);
    }
}
