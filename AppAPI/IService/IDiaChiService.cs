using AppData.Model;

namespace AppAPI.IService
{
    public interface IDiaChiService
    {
        List<DiaChi> GetDiaChi(string? name);
        DiaChi GetDiaChiById(Guid id);
        bool Create(DiaChi diaChi);
        bool Update(DiaChi diaChi);
        bool Delete(Guid id);
        Task<List<DiaChi>> GetDiaChiByIdKH(Guid id);
        bool UpdateDCbyIdKH(Guid id,DiaChi diaChi);
    }
}
