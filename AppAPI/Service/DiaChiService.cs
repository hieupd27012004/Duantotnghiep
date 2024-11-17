using AppAPI.IRepository;
using AppAPI.IService;
using AppData.Model;

namespace AppAPI.Service
{
    public class DiaChiService : IDiaChiService
    {
        private readonly IDiaChiRepo _repository;
        public DiaChiService(IDiaChiRepo repo)
        {
            _repository = repo;
        }
        public bool Create(DiaChi diaChi)
        {
           return _repository.Create(diaChi);
        }

        public bool Delete(Guid id)
        {
            return _repository.Delete(id);
        }

        public List<DiaChi> GetDiaChi(string? name)
        {
            return _repository.GetDiaChi(name);
        }

        public DiaChi GetDiaChiById(Guid id)
        {
            return _repository.GetDiaChiById(id);
        }

        public bool Update(DiaChi diaChi)
        {
            return _repository.Update(diaChi);
        }
        public async Task<List<DiaChi>> GetDiaChiByIdKH(Guid id)
        {
            return await _repository.GetDiaChiByIdKH(id);
        }
        public bool UpdateDCbyIdKH(Guid id, DiaChi diaChi)
        {
            return _repository.UpdateDCbyIdKH(id,diaChi);
        }
    }
}
