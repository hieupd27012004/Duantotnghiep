using AppData.Model;

namespace APPMVC.IService
{
    public interface IDiaChiService
    {
        Task<List<DiaChi>> GetDiaChi(string? name);
        Task<DiaChi> GetDiaChiById(Guid id);
        Task<List<DiaChi>> GetDiaChiByIdKH(Guid id);
        Task Create(DiaChi dc);
        Task Update(DiaChi dc);
        Task Delete(Guid id);
        Task UpdateDCbyIdKH(Guid id,DiaChi diaChi);
    }
}
