using AppAPI.IRepository;
using AppAPI.IService;
using AppData.Model;

namespace AppAPI.Service
{
    public class KieuDangService : IKieuDangService
    {
        private readonly IKieuDangRepo _repository;
        public KieuDangService(IKieuDangRepo repository)
        {
            _repository = repository;
        }
        public bool Create(KieuDang kieuDang)
        {
            return _repository.Create(kieuDang);
        }

        public bool Delete(Guid id)
        {
            return _repository.Delete(id);
        }

        public List<KieuDang> GetKieuDang()
        {
            return _repository.GetKieuDang();
        }

        public KieuDang GetKieuDangById(Guid id)
        {
            return _repository.GetKieuDangById(id);
        }

        public bool Update(KieuDang kieuDang)
        {
            return _repository.Update(kieuDang);
        }
    }
}
