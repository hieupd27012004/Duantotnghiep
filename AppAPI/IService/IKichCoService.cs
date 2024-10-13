using AppData.Model;

namespace AppAPI.IService
{
    public interface IKichCoService
    {
        List<KichCo> GetKichCo(string? name);
        KichCo GetKichCoById(Guid id);
        bool Create(KichCo kichCo);
        bool Update(KichCo kichCo);
        bool Delete(Guid id);
    }
}