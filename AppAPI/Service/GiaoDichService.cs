using AppAPI.IRepository;
using AppAPI.IService;
using AppData.Model;

namespace AppAPI.Service
{
    public class GiaoDichService : IGiaoDichService
    {
        private readonly IGiaoDichRepo _giaoDichRepository;

        public GiaoDichService(IGiaoDichRepo giaoDichRepository)
        {
            _giaoDichRepository = giaoDichRepository;
        }

        public async Task<List<GiaoDich>> GetAllAsync()
        {
            return await _giaoDichRepository.GetAllAsync();
        }

        public async Task<GiaoDich> GetByIdAsync(Guid id)
        {
            return await _giaoDichRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(GiaoDich giaoDich)
        {
            await _giaoDichRepository.AddAsync(giaoDich);
        }

        public async Task UpdateAsync(GiaoDich giaoDich)
        {
            await _giaoDichRepository.UpdateAsync(giaoDich);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _giaoDichRepository.DeleteAsync(id);
        }
    }
}
