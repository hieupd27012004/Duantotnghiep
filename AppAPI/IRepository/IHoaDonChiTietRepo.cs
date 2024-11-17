using AppData.Model;

namespace AppAPI.IRepository
{
    public interface IHoaDonChiTietRepo
    {
        Task<List<HoaDonChiTiet>> GetAllAsync();
        Task<HoaDonChiTiet> GetByIdAsync(Guid id);
        Task AddAsync(List<HoaDonChiTiet> hoaDonChiTietList);
        Task UpdateAsync(HoaDonChiTiet hoaDonChiTiet);
        Task DeleteAsync(Guid id);

        Task<List<HoaDonChiTiet>> GetByIdHoaDonAsync(Guid idHoaDon);
    }
}
