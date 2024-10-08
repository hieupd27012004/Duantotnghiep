using AppData.Model;

namespace APPMVC.Service
{
    public interface IServiceHinhAnh
    {
        Task<List<HinhAnh>> GetHinhAnhs();
        Task<HinhAnh> GetHinhAnhById(Guid id);
        Task Create(HinhAnh hinhAnh);
        Task Update(HinhAnh hinhAnh);
        Task Delete(Guid id);
    }
}
