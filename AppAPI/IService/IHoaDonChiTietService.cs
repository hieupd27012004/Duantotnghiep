using AppData.Model;

namespace AppAPI.IService
{
    public interface IHoaDonChiTietService
    {
        Task<List<HoaDonChiTiet>> GetAllAsync();
        Task<HoaDonChiTiet> GetByIdAsync(Guid id);
        Task AddAsync(HoaDonChiTiet hoaDonChiTiet);
        Task UpdateAsync(HoaDonChiTiet hoaDonChiTiet);
        Task DeleteAsync(Guid id);
    }
}
