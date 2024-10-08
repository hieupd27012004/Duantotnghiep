using AppAPI.IRepository;
using AppAPI.IService;
using AppData.Model;

namespace AppAPI.Service
{
    public class ThuongHieuService : IThuongHieuService
	{
		public IThuongHiepRepo _repo;
        public ThuongHieuService(IThuongHiepRepo repo)
        {
            _repo = repo;
        }

        public async Task<ThuongHieu> CreateTH(ThuongHieu th)
        {
            return await _repo.CreateTH(th);
        }

        public async Task DeleteTH(Guid id)
        {
             await _repo.DeleteTH(id);
        }

        public async Task<List<ThuongHieu>> GetAllThuongHieu()
        {
            return await _repo.GetAllThuongHieu();
        }

        public async Task<ThuongHieu> GetIdThuongHieu(Guid id)
        {
            return await _repo.GetIdThuongHieu(id);
        }

        public async Task<ThuongHieu> UpdateTH(ThuongHieu th)
        {
           return await _repo.UpdateTH(th); 
        }
    }
}
