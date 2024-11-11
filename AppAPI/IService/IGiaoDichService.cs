using AppData.Model;

namespace AppAPI.IService
{
    public interface IGiaoDichService
    {
        Task<List<GiaoDich>> GetAllAsync();
        Task<GiaoDich> GetByIdAsync(Guid id);
        Task AddAsync(GiaoDich giaoDich);
        Task UpdateAsync(GiaoDich giaoDich);
        Task DeleteAsync(Guid id);

    }
}
