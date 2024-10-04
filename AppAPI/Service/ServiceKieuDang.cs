using AppAPI.Repository;
using AppData.Model;

namespace AppAPI.Service
{
    public class ServiceKieuDang : IServiceKieuDang
    {
        private readonly IRepoKieuDang _repository;
        public ServiceKieuDang(IRepoKieuDang repository)
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
