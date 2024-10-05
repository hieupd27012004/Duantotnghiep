using AppData.Model;

namespace AppAPI.Service
{
    public interface IDanhMucService
    {
        Task<List<DanhMuc>> GetAllDanhMuc();
        Task<DanhMuc> GetIdDanhMuc(Guid id);
        Task<DanhMuc> CreateDM(DanhMuc dm);
        Task<DanhMuc> UpdateDM(DanhMuc dm);
        Task DeleteDM(Guid id);
    }
}
