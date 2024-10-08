using AppAPI.IRepository;
using AppAPI.IService;
using AppData.Model;

namespace AppAPI.Service
{
    public class DanhMucService : IDanhMucService
    {
        public IDanhMucRepo _repo;
        public DanhMucService(IDanhMucRepo repo)
        {
            _repo = repo;
        }

        public async Task<DanhMuc> CreateDM(DanhMuc dm)
        {
            return await _repo.CreateDM(dm);
        }

        public async Task DeleteDM(Guid id)
        {
            await _repo.DeleteDM(id);
        }

        public async Task<List<DanhMuc>> GetAllDanhMuc()
        {
            return await _repo.GetAllDanhMuc();
        }

        public async Task<DanhMuc> GetIdDanhMuc(Guid id)
        {
            return await _repo.GetIdDanhMuc(id);
        }

        public async Task<DanhMuc> UpdateDM(DanhMuc dm)
        {
            return await _repo.UpdateDM(dm);
        }
    }
}
