using AppData.Model;

namespace AppAPI.IService
{
    public interface IHoaDonService
    {
        Task<List<HoaDon>> GetAllAsync(); 
        Task<HoaDon> GetByIdAsync(Guid id);
        Task AddAsync(HoaDon hoaDon);
        Task UpdateAsync(HoaDon hoaDon);
        Task DeleteAsync(Guid id);
    }
}
