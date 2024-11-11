using AppData.Model;

namespace AppAPI.IRepository
{
    public interface IGiaoDichRepo
    {
        Task<List<GiaoDich>> GetAllAsync();
        Task<GiaoDich> GetByIdAsync(Guid id);
        Task AddAsync(GiaoDich giaoDich);
        Task UpdateAsync(GiaoDich giaoDich);
        Task DeleteAsync(Guid id);
    }
}
