using AppData.Model;

namespace AppAPI.IRepository
{
    public interface IHoaDonChiTietRepo
    {
        Task<List<HoaDonChiTiet>> GetAllAsync();
        Task<HoaDonChiTiet> GetByIdAsync(Guid id);
        Task AddAsync(HoaDonChiTiet hoaDonChiTiet);
        Task UpdateAsync(HoaDonChiTiet hoaDonChiTiet);
        Task DeleteAsync(Guid id);
    }
}
