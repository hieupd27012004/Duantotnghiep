using AppData.Model;

namespace APPMVC.IService
{
    public interface IDanhMucService
    {
        Task<List<DanhMuc>> GetAllDanhMuc();
        Task<DanhMuc> GetIdDanhMuc(Guid id);
        Task Create(DanhMuc danhMuc);
        Task Delete(Guid id);
        Task UpDate(DanhMuc danhMuc);
    }
}
